using ETrade.Business.Abstract;
using ETrade.Business.Helpers;
using ETrade.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETrade.Presentation.Controllers
{
    public class ContactController : Controller
    {
        private readonly ICookieHelper _cookieHelper;
        private readonly IUserTokenService _userTokenService;
        private readonly IUserService _userService;
        private readonly IContactService _contactService;

        public ContactController(ICookieHelper cookieHelper, IUserTokenService userTokenService, IUserService userService, IContactService contactService)
        {
            _cookieHelper = cookieHelper;
            _userTokenService = userTokenService;
            _userService = userService;
            _contactService = contactService;
        }        
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult ContactViewOk(string inputName, string inputEmail, string inputSubject, string inputMessage)
        {
            
            //if (string.IsNullOrEmpty(user))
            //{
            //    return Json("Login");
            //}
            

            Contact contact = new Contact();
            contact.Name = inputName;
            contact.Email = inputEmail;
            contact.Subject = inputSubject;
            contact.Message = inputMessage;
            var user = _cookieHelper.Get(CookieTypes.user, Request);
            var userId = _userTokenService.GetTokenUserId(user);
            var userDetail = _userService.GetById(userId);
            
            if (userDetail != null)
            {
                contact.UserId = userId;
            }
            else
            {
                contact.UserId = 0;
            }
            contact.Date = System.DateTime.Now;

            if (inputName==null || inputEmail==null || inputSubject==null || inputMessage==null )
            {
                return Json("Danger");
            }
            
            _contactService.Add(contact);
            
            return Json("Ok");
            


        }
    }
}
