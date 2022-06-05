using ETrade.Business.Abstract;
using ETrade.Business.Helpers;
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
    public class HomeController : Controller
    {
        private readonly ICookieHelper _cookieHelper;
        private readonly IUserService _userService;
        private readonly IUserTokenService _userTokenService;

        public HomeController(ICookieHelper cookieHelper, IUserService userService, IUserTokenService userTokenService)
        {
            _cookieHelper = cookieHelper;
            _userService = userService;
            _userTokenService = userTokenService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(AdminLoginModel model)
        {
            if (ModelState.IsValid)
            {
                var login = _userService.AdminLogin(model.Email, model.Password,model.IsDeleted);
                if (login==null)
                {
                    ModelState.AddModelError("LoginError", "Giriş Başarısız");
                }
                else
                {
                    string guid = Guid.NewGuid().ToString();
                    _cookieHelper.Add(CookieTypes.admin, guid, DateTime.Now.AddDays(10), Response);
                    _userTokenService.Add(guid, login.Id);

                    TempData.Put("message", new ResultMessage()
                    {
                        Title = "Login Transactions",
                        Message = "You Have Been Securely Logged Into The Admin Panel",
                        Css = "success"

                    });
                    return RedirectToAction("Index", "Dashboard");
                }
            }
            else
            {
                // bu model bir şekilde hatalı
            }
            return View();
        }
    }
}
