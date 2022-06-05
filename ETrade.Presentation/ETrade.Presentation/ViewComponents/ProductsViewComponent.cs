using ETrade.Business.Abstract;
using ETrade.Presentation.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETrade.Presentation.ViewComponents
{
    public class ProductsViewComponent:ViewComponent
    {
        private readonly IProductService _productService;
        public ProductsViewComponent(IProductService productService)
        {
            _productService = productService;
        }
        public IViewComponentResult Invoke()
        {
            var products = _productService.ProductWithImages();
          
            return View(products);
        }
    }
}
