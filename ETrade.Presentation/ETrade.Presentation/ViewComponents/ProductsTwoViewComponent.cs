using ETrade.Business.Abstract;
using ETrade.Presentation.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETrade.Presentation.ViewComponents
{
    public class ProductsTwoViewComponent:ViewComponent
    {
        private readonly IProductService _productService;

        public ProductsTwoViewComponent(IProductService productService)
        {
            _productService = productService;
        }
        public IViewComponentResult Invoke()
        {
            ProductMostViewModel model = new ProductMostViewModel();
            model.MostView = _productService.ProductWithImages().OrderByDescending(x => x.Counter).Take(4).ToList();
            return View(model);
        }
    }
}
