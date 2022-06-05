using ETrade.Business.Abstract;
using ETrade.Business.Helpers;
using ETrade.Presentation.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETrade.Presentation.ViewComponents
{
    public class NavbarViewComponent:ViewComponent
    {
        private readonly IUserService _userService;
        private readonly IUserTokenService _userTokenService;
        private readonly ICookieHelper _cookieHelper;
        
        public NavbarViewComponent(IUserService userService, IUserTokenService userTokenService, ICookieHelper cookieHelper)
        {
            _userService = userService;
            _userTokenService = userTokenService;
            _cookieHelper = cookieHelper;
            
        }
        public IViewComponentResult Invoke()
        {
            var cookie = _cookieHelper.Get(CookieTypes.user, Request);
            var tokenDetail = _userTokenService.Get(cookie);
            if (cookie==null || tokenDetail==null)
            {
                ViewData["email"] = null;
            }
            else
            {
                ViewData["email"]= _userService.GetById(tokenDetail.UserId).Email;
            }           
            return View();
        }
        
        
    }
}
