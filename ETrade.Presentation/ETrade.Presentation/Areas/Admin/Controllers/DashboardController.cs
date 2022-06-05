using ETrade.Presentation.Areas.Admin.Helpers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETrade.Presentation.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        private readonly IAdminChecker _adminChecker;

        public DashboardController(IAdminChecker adminChecker)
        {
            _adminChecker = adminChecker;
        }

        public IActionResult Index()
        {
            var check = _adminChecker.Check(Request);
            if (check==false)
            {
                return Redirect("/admin");
            }
            return View();
        }
    }
}
