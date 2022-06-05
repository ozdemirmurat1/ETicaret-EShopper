using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETrade.Presentation.Areas.Admin.ViewComponents
{
    [Area("Admin")]
    public class FooterAdminViewComponent:ViewComponent
    {
        public FooterAdminViewComponent()
        {

        }
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
