using ETrade.Business.Helpers;
using ETrade.Presentation.Helpers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETrade.Presentation.ViewComponents
{
    public class OrderDetailViewComponent:ViewComponent
    {
        private readonly ICookieHelper _cookieHelper;
        public OrderDetailViewComponent(ICookieHelper cookieHelper)
        {
            _cookieHelper = cookieHelper;
        }
        public IViewComponentResult Invoke()
        {
            var tokenKey = _cookieHelper.Get(CookieTypes.basket, Request);
            var basket = BasketHelper.GetMethods.Get(tokenKey);

            return View(basket);
        }
    }
}
