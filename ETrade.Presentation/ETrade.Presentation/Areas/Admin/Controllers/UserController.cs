using ETrade.Business.Abstract;
using ETrade.Business.Helpers;
using ETrade.Entities;
using ETrade.Presentation.Areas.Admin.Models;
using ETrade.Presentation.Extensions;
using ETrade.Presentation.Helpers;
using ETrade.Presentation.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETrade.Presentation.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly IStringHelper _stringHelper;
        private readonly IUserTokenService _userTokenService;
        private readonly ICookieHelper _cookieHelper;

        public UserController(IUserService userService, IStringHelper stringHelper, IUserTokenService userTokenService, ICookieHelper cookieHelper)
        {
            _userService = userService;
            _stringHelper = stringHelper;
            _userTokenService = userTokenService;
            _cookieHelper = cookieHelper;
        }

        public IActionResult Index()
        {
            UserListViewModel usersListViewModel = new UserListViewModel();
            usersListViewModel.List = _userService.List();
            return View(usersListViewModel);
        }
        public IActionResult Delete(int id)
        {
            var cookie = _cookieHelper.Get(CookieTypes.admin, Request);
            if (cookie==null)
            {
                return RedirectToAction("Index");
            }
            var adminUserId = _userTokenService.GetTokenUserId(cookie);
            var user = _userService.GetById(id);
            user.Status = false;
            user.DeleteUser = adminUserId;
            user.DeletedIp = Request.Host.Value;
            user.DeletedPc = Request.Headers["REMOTE_HOST"];
            user.DeletedDate = System.DateTime.Now;
            user.IsDeleted = true;

            _userService.Delete(user);

            TempData.Put("message", new ResultMessage()
            {
                Title = "User Transactions",
                Message = "The User Has Been Successfully Deleted!",
                Css = "success"

            });

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Add(UserAddEditModel userAddModel)
        {
            if (!ModelState.IsValid)
            {
                return View(userAddModel);               
            }
            else
            {
                _userService.Add(new User()
                {
                    Email = userAddModel.Email,
                    Password = _stringHelper.ToMd5(userAddModel.Password),
                    IsAdmin = userAddModel.IsAdmin,
                    Status = userAddModel.Status,
                    FirstName=userAddModel.FirstName,
                    LastName=userAddModel.LastName,
                    Gender=userAddModel.Gender
                });
                TempData.Put("message", new ResultMessage()
                {
                    Title = "User Transactions",
                    Message = "The User Has Been Successfully Added!",
                    Css = "success"

                });
                return RedirectToAction("Index");
            }
            
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var user = _userService.GetById(id);
            if (user!=null)
            {
                UserAddEditModel userEditModel = new UserAddEditModel
                {
                    Email = user.Email,
                    IsAdmin = user.IsAdmin.Value,
                    Status = user.Status.Value,
                    UserId = AESHash.AES_Encrypt(id.ToString()),
                    FirstName=user.FirstName,
                    LastName=user.LastName,
                    Gender=user.Gender,                  
                };
                
                return View(userEditModel);
            }
            else
            {
                TempData["error"] = "Kullanıcı Bulunamadı";
                return RedirectToAction("Index");
            }
            
            
        }

        [HttpPost]
        public IActionResult Edit(UserAddEditModel model)
        {
            
            if(ModelState.IsValid)
            {
                User user = new User()
                {
                    Id = Convert.ToInt32(AESHash.AES_Decrypt(model.UserId)),
                    Email = model.Email,
                    Password = _stringHelper.ToMd5(model.Password),
                    IsAdmin = model.IsAdmin,
                    Status = model.IsAdmin,
                    FirstName=model.FirstName,
                    LastName=model.LastName,
                    Gender=model.Gender
                };
                _userService.Update(user);
                TempData.Put("message", new ResultMessage()
                {
                    Title = "User Transactions",
                    Message = "The User Has Been Successfully Edited!",
                    Css = "success"

                });
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
            
            
        }

        public IActionResult UserTokens()
        {
            UserTokensModel userTokensModel = new UserTokensModel();
            userTokensModel.userTokensModels = _userTokenService.List();
            return View(userTokensModel);
        }
        public IActionResult DeleteUserToken(int id)
        {
            var tokens = _userTokenService.GetById(id);
            _userTokenService.Delete(tokens);
            TempData.Put("message", new ResultMessage()
            {
                Title = "User Transactions",
                Message = "The UserToken Has Been Successfully Deleted!",
                Css = "info"

            });
            return RedirectToAction("UserTokens");
        }
        
    }
}
