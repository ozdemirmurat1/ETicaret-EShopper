using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETrade.Presentation.Areas.Admin.ViewComponents
{
    [Area("Admin")]
    public class ContentWrapperViewComponent:ViewComponent
    {
        public ContentWrapperViewComponent()
        {

        }
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
