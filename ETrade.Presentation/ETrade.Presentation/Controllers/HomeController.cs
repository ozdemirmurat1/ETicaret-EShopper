using ETrade.Business.Abstract;
using ETrade.Business.Helpers;
using ETrade.Entities;
using ETrade.Presentation.Extensions;
using ETrade.Presentation.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETrade.Presentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICookieHelper _cookieHelper;
        private readonly IUserService _userService;
        private readonly IUserTokenService _userTokenService;
        private readonly IStringHelper _stringHelper;

        public HomeController(ICookieHelper cookieHelper, IUserService userService, IUserTokenService userTokenService, IStringHelper stringHelper)
        {
            _cookieHelper = cookieHelper;
            _userService = userService;
            _userTokenService = userTokenService;
            _stringHelper = stringHelper;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            // IsValid modelin geçerli olduğu anlamına gelir.
            // getbyId ile user bilgilerini çek.         

            if (ModelState.IsValid)
            {
                var login = _userService.Login(model.Email,model.Password,model.ısDeleted);
                
                if (login==null)
                {
                    ModelState.AddModelError("LoginError", "Giriş Başarısız");
                    
                }
                
                else
                {
                    string guid = Guid.NewGuid().ToString();
                    _cookieHelper.Add(CookieTypes.user, guid,DateTime.Now.AddDays(10),Response);
                    _userTokenService.Add(guid, login.Id);

                    TempData.Put("message", new ResultMessage()
                    {
                        Title = "Login Transactions",
                        Message= "You Have Been Securely Logged In",
                        Css="success"

                    });
                       

                    return RedirectToAction("Index", "Home");

                    
                }              
            }
            else
            {
                // Bu Model Hatalı
            }
            return View();
        }

        public IActionResult Logout()
        {
            _cookieHelper.Delete(CookieTypes.user, Response);
            TempData.Put("message", new ResultMessage()
            {
                Title = "Login Transactions",
                Message = "You Have Been Securely Logged Out",
                Css = "info"

            });
            return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        public IActionResult Add(kUserAddViewModel model)
        {
            if (ModelState.IsValid)
            {
                _userService.Add(new User()
                {
                    Email = model.Email,
                    FirstName=model.FirstName,
                    LastName=model.LastName,
                    Gender=model.Gender,
                    Password = _stringHelper.ToMd5(model.Password),
                    IsAdmin = false,
                    Status = true
                });
                TempData.Put("message", new ResultMessage()
                {
                    Title = "Login User Transactions",
                    Message = "Registration Successful",
                    Css = "success"

                });


                return RedirectToAction("Index", "Home");

            }
            return View(model);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }


    }
}
