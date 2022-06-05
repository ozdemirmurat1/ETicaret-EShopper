using ETrade.Business.Abstract;
using ETrade.Presentation.Areas.Admin.Models;
using ETrade.Presentation.Extensions;
using ETrade.Presentation.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETrade.Presentation.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OrdersController : Controller
    {
        private readonly IOrderService _orderService;

        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List()
        {
            OrdersListViewModel ordersListViewModel = new OrdersListViewModel();
            ordersListViewModel.OrderList = _orderService.List();
            return View(ordersListViewModel);
        }
        public IActionResult Delete(int id)
        {
            var orders = _orderService.GetById(id);
            _orderService.Delete(orders);
            TempData.Put("message", new ResultMessage()
            {
                Title = "Order Transactions",
                Message = "The Order Has Been Successfully Deleted!",
                Css = "info"

            });
            return RedirectToAction("List");
        }
        public IActionResult OrderDetail()
        {
            OrdersListViewModel ordersListViewModel = new OrdersListViewModel();
            ordersListViewModel.OrderList = _orderService.List();
            return View(ordersListViewModel);
        }
    }
}
