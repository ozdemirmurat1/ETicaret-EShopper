using ETrade.Business.Abstract;
using ETrade.DataAccess.Abstract;
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
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List()
        {
            ContactListViewModel contactListViewModel = new ContactListViewModel();
            contactListViewModel.ContactList = _contactService.List();
            return View(contactListViewModel);
        }
        public IActionResult Delete(int id)
        {
            var contact = _contactService.GetById(id);
            _contactService.Delete(contact);
            TempData.Put("message", new ResultMessage()
            {
                Title = "Contact Transactions",
                Message = "The Contact Has Been Successfully Deleted!",
                Css = "info"

            });
            return RedirectToAction("List");
        }
    }
}
