using AromaShop.Models;
using AromaShop.Models.ViewModels;
using AromaShop.Services.IRepository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AromaShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ProductController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Upsert(int? id)
        {
            List<SpecDetails> specDetails = GetSpecList();
            ProductCreateOrUpdateVM productVM;
            if (id == null || id == 0)
            {
                // return ViewModel to create view
                productVM = new()
                {
                    Product = new Product(),
                    CategorySelectList = GetCategorySelectList(),
                    BrandSelectList = GetBrandSelectList(),
                    ColorSelectList = GetColorSelectList(),
                    SpecDetails = specDetails
                };
            }
            else
            {
                // return ViewModel to update view
                var productFromDb = _unitOfWork.Product.Get(u => u.Id == id);
                var productColors = _unitOfWork.ProductColor.Get(u => u.ProductId == id);
                var productSpecifications = _unitOfWork.ProductSpecification.GetAll(u => u.ProductId == id).ToList();

                // map ProductSpecification to specDetails
                for (int i = 0; i < productSpecifications.Count; i++)
                {
                    foreach (var spec in specDetails)
                    {
                        if (productSpecifications[i].SpecificationId == spec.Id)
                        {
                            spec.Description = productSpecifications[i].Description;
                        }
                    }
                }

                productVM = new()
                {
                    Product = productFromDb,
                    CategorySelectList = GetCategorySelectList(),
                    BrandSelectList = GetBrandSelectList(),
                    ColorSelectList = GetColorSelectList(),
                    SpecDetails = specDetails,
                    ColorIds = productColors.ColorId
                };
            }

            return View(productVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(ProductCreateOrUpdateVM model, IFormFile? file)
        {
            if (ModelState.IsValid)
            {
                // handle image upload
                model.Product.ImagePath = Ultility.Util.UploadImage(model.Product.ImagePath, file, _webHostEnvironment.WebRootPath, "product");
                
                if (model.Product.Id == 0)
                {
                    // add new product
                    _unitOfWork.Product.Add(model.Product);
                    _unitOfWork.Save();
                    int newAddedProductId = model.Product.Id;

                    // add ProductColor
                    ProductColor productColor = new();
                    productColor.ProductId = newAddedProductId;
                    productColor.ColorId = model.ColorIds;
                    _unitOfWork.ProductColor.Add(productColor);

                    // add ProductSpecification
                    ProductSpecification productSpecification = new();
                    productSpecification.ProductId = newAddedProductId;
                    foreach (var spec in model.SpecDetails)
                    {
                        // add non-null field
                        if (!string.IsNullOrEmpty(spec.Description))
                        {
                            productSpecification.SpecificationId = spec.Id;
                            productSpecification.Description = spec.Description;
                            _unitOfWork.ProductSpecification.Add(productSpecification);
                        }
                    }
                    _unitOfWork.Save();

                    TempData["success"] = "Created successfullly";
                }
                else
                {
                    // update product
                    var productFromDb = _unitOfWork.Product.Get(u => u.Id == model.Product.Id);
                    productFromDb = model.Product;
                    _unitOfWork.Product.Update(productFromDb);

                    // update ProductColor
                    var productColorFromDb = _unitOfWork.ProductColor.Get(u => u.ProductId == model.Product.Id);
                    productColorFromDb.ProductId = model.Product.Id;
                    productColorFromDb.ColorId = Convert.ToInt32(model.ColorIds);
                    _unitOfWork.ProductColor.Update(productColorFromDb);

                    // update ProductSpecification
                    var productSpecificationsFromDb = _unitOfWork.ProductSpecification.GetAll(u => u.ProductId == model.Product.Id).ToList();
                    foreach (var spec in model.SpecDetails)
                    {
                        bool isExisted = false;
                        // case: edit or remove existing field -> for loop to edit or update field
                        foreach (var item in productSpecificationsFromDb)
                        {
                            if (item.SpecificationId == spec.Id)
                            {
                                isExisted = true; // this spec existed in db
                                item.Description = spec.Description;
                                _unitOfWork.ProductSpecification.Update(item);
                            }
                        }
                            
                        // case: add more field of specs to product
                        if (!string.IsNullOrEmpty(spec.Description) && !isExisted)
                        {
                            ProductSpecification productSpecification = new();
                            productSpecification.ProductId = model.Product.Id;
                            productSpecification.SpecificationId = spec.Id;
                            productSpecification.Description = spec.Description;

                            _unitOfWork.ProductSpecification.Add(productSpecification);
                        }
                    }

                    TempData["success"] = "Updated successfullly";
                }
                _unitOfWork.Save();

                return RedirectToAction(nameof(Index));
            }

            // submit fail -> reload model
            ProductCreateOrUpdateVM productVM = new()
            {
                Product = new Product(),
                CategorySelectList = GetCategorySelectList(),
                BrandSelectList = GetBrandSelectList(),
                ColorSelectList = GetColorSelectList(),
                SpecDetails = GetSpecList()
            };

            return View(model);
        }


        #region API

        public IActionResult GetAll()
        {
            var productList = _unitOfWork.Product.GetAll();
            foreach (var product in productList)
            {
                product.Category = _unitOfWork.Category.Get(u => u.Id == product.CategoryId);
                product.Brand = _unitOfWork.Brand.Get(u => u.Id == product.BrandId);
                product.ProductColor = _unitOfWork.ProductColor.GetAll(u => u.ProductId == product.Id).ToList();
                product.ProductSpecification = _unitOfWork.ProductSpecification.GetAll(u => u.ProductId == product.Id).ToList();
            }
            return Json(new { data = productList });
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var objFromDb = _unitOfWork.Product.Get(u => u.Id == id);
            if (objFromDb == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }

            // delete image
            Ultility.Util.DeleteImage(objFromDb.ImagePath, _webHostEnvironment.WebRootPath);

            // delete relevant ProductColor records
            var productColors = _unitOfWork.ProductColor.GetAll(u => u.ProductId == id);
            _unitOfWork.ProductColor.RemoveRange(productColors);

            // delete relevant ProductSpecification records
            var productSpecifications = _unitOfWork.ProductSpecification.GetAll(u => u.ProductId == id);
            _unitOfWork.ProductSpecification.RemoveRange(productSpecifications);

            _unitOfWork.Product.Remove(objFromDb);
            _unitOfWork.Save();

            return Json(new { success = true, message = "Delete Successfully" });
        }

        #endregion


        #region Local Method
        private IEnumerable<SelectListItem> GetColorSelectList()
        {
            return _unitOfWork.Color.GetAll()
                                .Select(u => new SelectListItem
                                {
                                    Text = u.Name,
                                    Value = u.Id.ToString()
                                });
        }

        private IEnumerable<SelectListItem> GetBrandSelectList()
        {
            return _unitOfWork.Brand.GetAll()
                                .Select(u => new SelectListItem
                                {
                                    Text = u.Name,
                                    Value = u.Id.ToString()
                                });
        }

        private IEnumerable<SelectListItem> GetCategorySelectList()
        {
            return _unitOfWork.Category.GetAll()
                                .Select(u => new SelectListItem
                                {
                                    Text = u.Name,
                                    Value = u.Id.ToString()
                                });
        }

        private List<SpecDetails> GetSpecList()
        {
            var specList = _unitOfWork.Specification.GetAll();
            var specs = new List<SpecDetails>();
            foreach (var spec in specList)
            {
                specs.Add(new SpecDetails
                {
                    Id = spec.Id,
                    Name = spec.Name
                });
            }

            return specs;
        }
        #endregion
    }
}
