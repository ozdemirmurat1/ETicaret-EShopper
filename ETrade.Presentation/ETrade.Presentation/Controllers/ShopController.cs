using ETrade.Business.Abstract;
using ETrade.Presentation.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETrade.Presentation.Controllers
{
    public class ShopController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;

        public ShopController(ICategoryService categoryService, IProductService productService)
        {
            _categoryService = categoryService;
            _productService = productService;
        }

        public IActionResult Index(string name,int? page)
        {
            var category = _categoryService.GetCategory(name);
            var products = _productService.GetCategoryProducts(category.Id,page);

            ShopViewModel model = new()
            {
                Products=products,
                CurrentPage=page ?? 1,
                TotalPage=_productService.TotalPage(category.Id),
                CategoryName=name
            };

            return View(model);
        }
    }
}
