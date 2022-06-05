using ETrade.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETrade.Presentation.Areas.Admin.ViewComponents
{
    [Area("Admin")]
    public class ContentWrapperContainsPageContentViewComponent:ViewComponent
    {
        private readonly IUserService _userService;
        private readonly IOrderService _orderService;
        public ContentWrapperContainsPageContentViewComponent(IUserService userService, IOrderService orderService)
        {
            _userService = userService;
            _orderService = orderService;
        }
        public IViewComponentResult Invoke()
        {
            var userCount = _userService.List().Count().ToString();
            ViewBag.userCount = userCount;

            var orderCount = _orderService.List().Count().ToString();
            ViewBag.orderCount = orderCount;
            return View();
        }
    }
}
