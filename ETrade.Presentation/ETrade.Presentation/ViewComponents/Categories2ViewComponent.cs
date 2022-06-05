using ETrade.Business.Abstract;
using ETrade.Presentation.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETrade.Presentation.ViewComponents
{
    public class Categories2ViewComponent:ViewComponent
    {
        private readonly ICategoryService _categoryService;
        public Categories2ViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public IViewComponentResult Invoke()
        {

            var result = _categoryService.GetAll();
            return View(result);
        }
    }
}
