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
    public class BasketController : Controller
    {
        private readonly ICookieHelper _cookieHelper;
        private readonly IProductService _productService;
        private readonly IProductImageService _productImageService;

        public BasketController(ICookieHelper cookieHelper, IProductService productService, IProductImageService productImageService)
        {
            _cookieHelper = cookieHelper;
            _productService = productService;
            _productImageService = productImageService;
        }

        public IActionResult Index()
        {
            var guidKey = GetGuid();        
            var basketDetail = BasketHelper.GetMethods.Get(guidKey);
            if (basketDetail == null)
            {
                return RedirectToAction("Index", "Home");
            }
            BasketIndexViewModel model = new();
            model.Basket = basketDetail;
            return View(model);
        }

        public JsonResult AddBasket(int quantityData,int productIdData)
        {
            string basketGuid = null;
            var basketCookieValue = _cookieHelper.Get(CookieTypes.basket,Request);
            if (basketCookieValue==null)
            {
                basketGuid = Guid.NewGuid().ToString();
                _cookieHelper.Add(CookieTypes.basket, basketGuid, DateTime.Now.AddDays(60), Response);
            }
            else
            {
                basketGuid = basketCookieValue;
            }
            var product = _productService.GetById(productIdData);
            var productImages = _productImageService.List(productIdData);

            BasketHelper.GetMethods.AddProduct(new BasketProduct
            {
                Image=productImages.First().Name,
                ProductId=productIdData,
                Quantity=quantityData,
                Product=product
            
            }, basketGuid,0,quantityData);


            var basketDetail = BasketHelper.GetMethods.GetBasketDetails(basketGuid);
            string basketHtml= $"<a href=\"/mybasket\" class=\"btn border\"><i class=\"fas fa-shopping-cart text-primary\"></i><span class=\"badge\">{basketDetail.Item2}</span><span class=\"product-count text-lg-right\">{basketDetail.Item1}</span></a>";

            return Json(basketHtml);


        }
        public JsonResult ReduceBasket(int quantityData, int productIdData)
        {
            string basketGuid = null;
            var basketCookieValue = _cookieHelper.Get(CookieTypes.basket, Request);
            if (basketCookieValue == null)
            {
                basketGuid = Guid.NewGuid().ToString();
                _cookieHelper.Add(CookieTypes.basket, basketGuid, DateTime.Now.AddDays(60), Response);
            }
            else
            {
                basketGuid = basketCookieValue;
            }
            var product = _productService.GetById(productIdData);
            var productImages = _productImageService.List(productIdData);

            BasketHelper.GetMethods.ReduceProduct(new BasketProduct
            {
                Image=productImages.First().Name,
                ProductId=productIdData,
                Quantity=quantityData,
                Product=product

            }, basketGuid, 0, quantityData);

            var basketDetail = BasketHelper.GetMethods.GetBasketDetails(basketGuid);
            string basketHtml = $"<a href=\"/mybasket\" class=\"btn border\"><i class=\"fas fa-shopping-cart text-primary\"></i><span class=\"badge\">{basketDetail.Item2}</span><span class=\"product-count text-lg-right\">{basketDetail.Item1}</span></a>";

            return Json(basketHtml);
        }

        public JsonResult GetBasket(int quantityData, int productIdData)
        {
            string basketGuid = null;
            var basketCookieValue = _cookieHelper.Get(CookieTypes.basket, Request);
            if (basketCookieValue == null)
            {
                basketGuid = Guid.NewGuid().ToString();
                _cookieHelper.Add(CookieTypes.basket, basketGuid, DateTime.Now.AddDays(50),Response);
            }
            else
            {
                basketGuid = basketCookieValue;
            }

            var basketDetail = BasketHelper.GetMethods.GetBasketDetails(basketGuid);
            if (basketDetail == null)
            {
                return Json($"<a href=\"/mybasket\" class=\"btn border\"><i class=\"fas fa-shopping-cart text-primary\"></i><span class=\"badge\">0</span><span class=\"product - count text - lg - right\">0</span></a>");
            }
            string basketHtml = $"<a href=\"/mybasket\" class=\"btn border\"><i class=\"fas fa-shopping-cart text-primary\"></i><span class=\"badge\">{basketDetail.Item2}</span><span class=\"product - count text - lg - right\">{basketDetail.Item1}</span></a>";           

            //string basketHtml = $"<a href=\"\" class=\"btn border\"><i class=\"fas fa-shopping-cart text-primary\"></i><span class=\"badge\">{basketDetail.Item2}</span><span class=\"product - count text - lg - right\">{basketDetail.Item1}</span></a>";

            return Json(basketHtml);
        }

        private string GetGuid()
        {
            string basketGuid = null;
            var basketCookieValue = _cookieHelper.Get(CookieTypes.basket,Request);
            if (basketCookieValue == null)
            {
                basketGuid = Guid.NewGuid().ToString();
                _cookieHelper.Add(CookieTypes.basket, basketGuid, DateTime.Now.AddDays(60),Response);
            }
            else
            {
                basketGuid = basketCookieValue;
            }

            return basketGuid;
        }

        public IActionResult Minus(int Id)
        {
            var token = _cookieHelper.Get(CookieTypes.basket, Request);
            var products = BasketHelper.GetMethods.Get(token);
            var product = products.BasketProducts.FirstOrDefault(p => p.ProductId == Id);
            if (product.Quantity==1)
            {
                products.BasketProducts.Remove(product);
            }
            else
            {
                product.Quantity += -1;
            }

            return Redirect("/mybasket");
        }

        public IActionResult Plus(int Id)
        {
            var token = _cookieHelper.Get(CookieTypes.basket, Request);
            var products = BasketHelper.GetMethods.Get(token);
            var product = products.BasketProducts.FirstOrDefault(p => p.ProductId == Id);

            product.Quantity += 1;

            return Redirect("/mybasket");
        }
        public IActionResult RemoveProduct(int Id)
        {
            var token = _cookieHelper.Get(CookieTypes.basket, Request);
            var products = BasketHelper.GetMethods.Get(token);
            var product = products.BasketProducts.FirstOrDefault(p => p.ProductId == Id);

            products.BasketProducts.Remove(product);

            return Redirect("/mybasket");
        }

        
    }
}
