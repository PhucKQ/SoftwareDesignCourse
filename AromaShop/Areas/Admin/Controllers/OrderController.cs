using AromaShop.Models.ViewModels;
using AromaShop.Services.IRepository;
using AromaShop.Ultility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Stripe;
using System.Diagnostics;

namespace AromaShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = Ultility.Util.Role_Admin + "," + Ultility.Util.Role_Employee)]

    public class OrderController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public OrderController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int orderId)
        {
            var orderHeader = _unitOfWork.OrderHeader.Get(u => u.Id == orderId, includeProperties: "User");
            var orderDetails = _unitOfWork.OrderDetail.GetAll(u => u.OrderHeaderId == orderId);
            foreach (var item in orderDetails)
            {
                item.Product = _unitOfWork.Product.Get(u => u.Id == item.ProductId);
            }

            OrderVM orderVM = new()
            {
                OrderHeader = orderHeader,
                OrderDetails = orderDetails
            };

            return View(orderVM);
        }

        [Authorize(Roles = Util.Role_Admin + "," + Util.Role_Employee)]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateOrderDetail(OrderVM model)
        {

            var orderHeader = _unitOfWork.OrderHeader.Get(u => u.Id == model.OrderHeader.Id, includeProperties: "User");

            orderHeader.FirstName = model.OrderHeader.FirstName;
            orderHeader.LastName = model.OrderHeader.LastName;
            orderHeader.PhoneNumber = model.OrderHeader.PhoneNumber;
            orderHeader.StreetAddress = model.OrderHeader.StreetAddress;
            orderHeader.City = model.OrderHeader.City;
            orderHeader.State = model.OrderHeader.State;
            orderHeader.PostalCode = model.OrderHeader.PostalCode;
            if (!string.IsNullOrEmpty(model.OrderHeader.Carrier))
            {
                orderHeader.Carrier = model.OrderHeader.Carrier;
            }
            if (!string.IsNullOrEmpty(model.OrderHeader.TrackingNumber))
            {
                orderHeader.TrackingNumber = model.OrderHeader.TrackingNumber;
            }

            _unitOfWork.OrderHeader.Update(orderHeader);
            _unitOfWork.Save();

            TempData["success"] = "Order Details Updated Successfully";

            return RedirectToAction(nameof(Details), new { orderId = orderHeader.Id });
        }

        [Authorize(Roles = Util.Role_Admin + "," + Util.Role_Employee)]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult StartProcessing(OrderVM model)
        {
            _unitOfWork.OrderHeader.UpdateStatus(model.OrderHeader.Id, Util.StatusInProcess);
            _unitOfWork.Save();

            TempData["success"] = "Order Details Updated Successfully";

            return RedirectToAction(nameof(Details), new { orderId = model.OrderHeader.Id });
        }

        [Authorize(Roles = Util.Role_Admin + "," + Util.Role_Employee)]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ShipOrder(OrderVM model)
        {
            var orderHeader = _unitOfWork.OrderHeader.Get(u => u.Id == model.OrderHeader.Id);
            orderHeader.TrackingNumber = model.OrderHeader.TrackingNumber;
            orderHeader.Carrier = model.OrderHeader.Carrier;
            orderHeader.OrderStatus = Util.StatusShipped;
            orderHeader.ShippingDate = DateTime.Now;

            _unitOfWork.OrderHeader.Update(orderHeader);
            _unitOfWork.Save();

            TempData["success"] = "Order Details Updated Successfully";

            return RedirectToAction(nameof(Details), new { orderId = model.OrderHeader.Id });
        }

        [Authorize(Roles = Util.Role_Admin + "," + Util.Role_Employee)]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CancelOrder(OrderVM model)
        {
            var orderHeader = _unitOfWork.OrderHeader.Get(u => u.Id == model.OrderHeader.Id);
            if (orderHeader.PaymentStatus == Util.PaymentStatusApproved)
            {
                var options = new RefundCreateOptions
                {
                    Reason = RefundReasons.RequestedByCustomer,
                    PaymentIntent = orderHeader.PaymentIntentId
                };

                var service = new RefundService();
                Refund refund = service.Create(options);

                _unitOfWork.OrderHeader.UpdateStatus(model.OrderHeader.Id, Util.StatusCancelled, Util.StatusRefunded);
            }
            else
            {
                _unitOfWork.OrderHeader.UpdateStatus(model.OrderHeader.Id, Util.StatusCancelled, Util.StatusCancelled);
            }
            _unitOfWork.Save();

            TempData["success"] = "Order Cancelled Successfully";

            return RedirectToAction(nameof(Details), new { orderId = model.OrderHeader.Id });
        }


        #region API

        public IActionResult GetAll(string status)
        {
            var orderHeaderList = _unitOfWork.OrderHeader.GetAll(includeProperties: "User");

            switch (status)
            {
                case "pending":
                    orderHeaderList = orderHeaderList.Where(u => u.PaymentStatus == Util.PaymentStatusPending);
                    break;
                case "inprocess":
                    orderHeaderList = orderHeaderList.Where(u => u.OrderStatus == Util.StatusInProcess);
                    break;
                case "completed":
                    orderHeaderList = orderHeaderList.Where(u => u.OrderStatus == Util.StatusShipped);
                    break;
                case "approved":
                    orderHeaderList = orderHeaderList.Where(u => u.OrderStatus == Util.StatusApproved);
                    break;
            }

            return Json(new { data = orderHeaderList });
        }


        #endregion
    }
}
