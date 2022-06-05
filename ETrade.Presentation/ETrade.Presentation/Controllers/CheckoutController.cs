using ETrade.Business.Abstract;
using ETrade.Business.Helpers;
using ETrade.Entities;
using ETrade.Presentation.Helpers;
using ETrade.Presentation.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETrade.Presentation.Controllers
{
    public class CheckoutController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly ICookieHelper _cookieHelper;
        private readonly IUserTokenService _userTokenService;
        private readonly IUserService _userService;

        public CheckoutController(IOrderService orderService, ICookieHelper cookieHelper, IUserTokenService userTokenService, IUserService userService)
        {
            _orderService = orderService;
            _cookieHelper = cookieHelper;
            _userTokenService = userTokenService;
            _userService = userService;
        }

        public IActionResult Index()
        {
            CheckOutIndexViewModel model = new CheckOutIndexViewModel();

            var code = _cookieHelper.Get(CookieTypes.basket, Request);
            var products = BasketHelper.GetMethods.Get(code);

            if (products==null || products.BasketProducts==null)
            {
                return RedirectToAction("Index", "Home");
            }
            model.basketModel = products;
            return View(model);
        }

        [HttpPost]
        public JsonResult CheckOut(string inputFirstName, string inputLastName, string inputEmail, string inputPhone, string inputAddress, string inputCity)
        {
            var code = _cookieHelper.Get(CookieTypes.basket, Request);
            var user = _cookieHelper.Get(CookieTypes.user, Request);
            if (string.IsNullOrEmpty(user))
            {
                return Json("Login");
            }
            var userId = _userTokenService.GetTokenUserId(user);
            var userDetail = _userService.GetById(userId);
            if (userDetail==null)
            {
                return Json("Login");
            }
            var products = BasketHelper.GetMethods.Get(code);
            if (products==null || products.BasketProducts==null)
            {
                return Json("Error");
            }

            Order order = new Order();
            order.Address = inputAddress;
            order.FirstName = inputFirstName;
            order.LastName = inputLastName;
            order.Phone = inputPhone;
            order.Total = products.BasketProducts.Sum(x => x.Quantity * x.Product.Price);
            order.Date = System.DateTime.Now;
            order.City = Convert.ToInt32(inputCity);
            order.UserId = userId;
            order.Email = inputEmail;
            order.OrderDetail = JsonConvert.SerializeObject(products);

            if (inputAddress ==null || inputFirstName==null || inputLastName==null || inputPhone==null || inputCity==null)
            {
                return Json("Danger");
            }

            _orderService.Add(order);

            return Json("Ok");
        }
    }
}
