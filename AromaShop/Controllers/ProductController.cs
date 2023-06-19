using AromaShop.Models;
using AromaShop.Models.ViewModels;
using AromaShop.Services.IRepository;
using AromaShop.Ultility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;
using System.Security.Claims;

namespace AromaShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index(int category, int brand, int color,
                                    string search, int min = 0, int max = 100,
                                    int page = 1, string sort = "name", int limit = 9)
        {
            ViewBag.location = "shop";

            // get all products
            var listProducts = _unitOfWork.Product.GetAll(includeProperties: "Category");

            // handle query string
            if (category > 0)
            {
                ViewData["categorySelected"] = category;
                listProducts = listProducts.Where(p => p.CategoryId == category).ToList();
            }
            if (!string.IsNullOrEmpty(search))
            {
                ViewData["search"] = search;
                listProducts = listProducts.Where(p => p.Name.Contains(search)).ToList();
            }
            if (brand > 0)
            {
                ViewData["brandSelected"] = brand;
                listProducts = listProducts.Where(p => p.BrandId == brand).ToList();
            }
            if (color > 0)
            {
                ViewData["colorSelected"] = color;
                var productColors = _unitOfWork.ProductColor.GetAll(p => p.ColorId == color);

                listProducts = listProducts.Join(
                    productColors,
                    listProducts => listProducts.Id,
                    productColors => productColors.ProductId,
                    (listProducts, productColors) => listProducts
                );
            }

            // sorting case
            ViewData["sortSelected"] = sort;
            switch (sort)
            {
                case "name":
                    listProducts = listProducts.OrderBy(s => s.Name).ToList();
                    break;
                case "price":
                    listProducts = listProducts.OrderBy(s => s.Price).ToList();
                    break;
                case "price_desc":
                    listProducts = listProducts.OrderByDescending(s => s.Price).ToList();
                    break;
            }

            // pagination
            var paginatedProducts = PaginatedList<Product>.Create((IList<Product>)listProducts, page, limit);

            ProductViewModel productsVM = new()
            {
                Categories = GetCategoryList(listProducts),
                Brands = GetBrandList(listProducts),
                Colors = GetColorList(listProducts),
                PaginatedProducts = paginatedProducts,
                TopProducts = GetTopProducts(),
            };

            return View(productsVM);
        }


        public IActionResult Details(int productId)
        {
            // Get product by Id
            var product = _unitOfWork.Product.Get(u => u.Id == productId, includeProperties: "Category");
            if (product == null)
            {
                return NotFound();
            }

            var specs = _unitOfWork.ProductSpecification.GetAll(u => u.ProductId == productId);
            foreach (var spec in specs)
            {
                spec.Specification = _unitOfWork.Specification.Get(u => u.Id == spec.SpecificationId);
            }

            ProductDetailsViewModel productDetailsVM = new()
            {
                ProductId = productId,
                Product = product,
                ProductSpecification = specs,
                TopProducts = GetTopProducts(),
            };

            return View(productDetailsVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public IActionResult Details(ProductDetailsViewModel model, int productId)
        {
            var claims = (ClaimsIdentity)User.Identity;
            var userId = claims.FindFirst(ClaimTypes.NameIdentifier).Value;
            //model.UserId = userId;

            ShoppingCart cartFromDb = _unitOfWork.ShoppingCart.Get(u => u.UserId == userId && u.ProductId == productId);

            if (cartFromDb != null)
            {
                // shopping cart exist
                cartFromDb.Count += model.Count;
                _unitOfWork.ShoppingCart.Update(cartFromDb);
                _unitOfWork.Save();
            }
            else
            {
                // add new record to shoppingcart table
                ShoppingCart shoppingCart = new()
                {
                    ProductId = productId,
                    Count = model.Count,
                    UserId = userId,
                };
                _unitOfWork.ShoppingCart.Add(shoppingCart);
                _unitOfWork.Save();
                HttpContext.Session.SetInt32(Util.SessionCart,
                    _unitOfWork.ShoppingCart.GetAll(u => u.UserId == userId).Count());
            }

            return RedirectToAction(nameof(Index));
        }


        #region Private Method
        private IEnumerable<Category> GetCategoryList(IEnumerable<Product> sortedList)
        {
            // get Categories for sidebar
            var categories = _unitOfWork.Category.GetAll();
            foreach (var category in categories)
            {
                //category.Count = _unitOfWork.Product.GetAll(u => u.CategoryId == category.Id).Count();
                category.Count = sortedList.Where(u => u.CategoryId == category.Id).Count();
            }

            return categories;
        }

        private IEnumerable<Brand> GetBrandList(IEnumerable<Product> sortedList)
        {
            // get Brands for sidebar
            var brands = _unitOfWork.Brand.GetAll();
            foreach (var brand in brands)
            {
                //brand.Count = _unitOfWork.Product.GetAll(u => u.BrandId == brand.Id).Count();
                brand.Count = sortedList.Where(u => u.BrandId == brand.Id).Count();
            }

            return brands;
        }

        private IEnumerable<AromaShop.Models.Color> GetColorList(IEnumerable<Product> sortedList)
        {
            // get Colors for sidebar
            var colors = _unitOfWork.Color.GetAll();
            var productColors = _unitOfWork.ProductColor.GetAll();

            // lấy số lượng của mỗi màu trong danh sách sản phẩm đã được lọc ra sortedList
            foreach (var color in colors)
            {
                int count = 0;
                foreach (var item in sortedList)
                {
                    count += productColors.Where(u => u.ProductId == item.Id && u.ColorId == color.Id).Count();
                }
                color.Count = count;
            }

            return colors;
        }

        private List<Product> GetTopProducts()
        {
            // Get Top Products
            List<Product> topProducts = _unitOfWork.Product.GetAll(includeProperties: "Category")
                .OrderByDescending(t => t.OverallReview).Take(12).ToList();

            return topProducts;
        }

        #endregion
    }
}
