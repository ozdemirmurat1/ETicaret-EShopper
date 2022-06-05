using ETrade.Business.Abstract;
using ETrade.Business.Helpers;
using ETrade.Presentation.Helpers;
using ETrade.Presentation.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETrade.Presentation.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly IProductImageService _productImageService;
        private readonly ICookieHelper _cookieHelper;

        public ProductController(IProductService productService, IProductImageService productImageService, ICookieHelper cookieHelper)
        {
            _productService = productService;
            _productImageService = productImageService;
            _cookieHelper = cookieHelper;
        }

        public IActionResult Index(string name)
        {
            var product = _productService.GetBySeoName(name);
            if (product==null)
            {
                return RedirectToRoute("default");
            }
            var images = _productImageService.List(product.Id);
            
            ProductViewModel model = new ProductViewModel()
            {
               ProductDetail=product,
               Images=images,
                         
            };
            model.LastViews = _productService.ProductWithImages().OrderByDescending(x => Guid.NewGuid()).Take(5).ToList();
            _productService.CountUp(product);
            return View(model);         
        }

        [HttpGet]
        public IActionResult Review()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Review(ReviewViewModel model)
        {
            return View();
        }


    }
}
