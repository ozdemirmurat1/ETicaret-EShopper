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
    public class LikeController : Controller
    {
        private readonly ICookieHelper _cookieHelper;
        private readonly IProductService _productService;
        private readonly IProductImageService _productImageService;

        public LikeController(ICookieHelper cookieHelper, IProductService productService, IProductImageService productImageService)
        {
            _cookieHelper = cookieHelper;
            _productService = productService;
            _productImageService = productImageService;
        }

        public IActionResult Index()
        {
            var guidKey = GetGuid();
            var likeDetail = LikeHelper.GetMethods.Get(guidKey);
            if (likeDetail==null)
            {
                return RedirectToAction("Index", "Home");
            }
            LikeIndexViewModel model = new();
            model.Like = likeDetail;
            return View(model);
        }

        public JsonResult AddLike(int quantityData,int productIdData)
        {
            string likeGuid = null;
            var likeCookieValue = _cookieHelper.Get(CookieTypes.like, Request);
            if (likeCookieValue==null)
            {
                likeGuid = Guid.NewGuid().ToString();
                _cookieHelper.Add(CookieTypes.like, likeGuid, DateTime.Now.AddDays(60), Response);
            }
            else
            {
                likeGuid = likeCookieValue;
            }

            var product = _productService.GetById(productIdData);
            var productImages = _productImageService.List(productIdData);

            LikeHelper.GetMethods.AddProduct(new LikeProduct
            {
                Image=productImages.First().Name,
                ProductId=productIdData,
                Quantity=quantityData,
                Product=product

            },likeGuid,0,quantityData);

            var likeDetail = LikeHelper.GetMethods.GetLikeDetails(likeGuid);
            string likeHtml = $"<a href=\"/mylike\" class=\"btn border\"><i class= \"fas fa-heart text-primary\"></i><span class=\"badge\">{likeDetail}</span></a> ";

            return Json(likeHtml);

        }

        public JsonResult GetLike()
        {
            string likeGuid = null;
            var likeCookieValue = _cookieHelper.Get(CookieTypes.like, Request);
            if (likeCookieValue == null)
            {
                likeGuid = Guid.NewGuid().ToString();
                _cookieHelper.Add(CookieTypes.like, likeGuid, DateTime.Now.AddDays(60), Response);
            }
            else
            {
                likeGuid = likeCookieValue;
            }

            var likeDetail = LikeHelper.GetMethods.GetLikeDetails(likeGuid);
            if (likeDetail==null)
            {
                return Json($"<a href=\"/mylike\" class=\"btn border\"><i class= \"fas fa-heart text-primary\"></i><span class=\"badge\">0</span></a>");
            }
            string likeHtml = $"<a href=\"/mylike\" class=\"btn border\"><i class= \"fas fa-heart text-primary\"></i><span class=\"badge\">{likeDetail}</span></a> ";

            return Json(likeHtml);


        }

        private string GetGuid()
        {
            string likeGuid = null;
            var likeCookieValue = _cookieHelper.Get(CookieTypes.like, Request);
            if (likeCookieValue == null)
            {
                likeGuid = Guid.NewGuid().ToString();
                _cookieHelper.Add(CookieTypes.like, likeGuid, DateTime.Now.AddDays(60), Response);
            }
            else
            {
                likeGuid = likeCookieValue;
            }
            return likeGuid;
        }

        public IActionResult Minus(int Id)
        {
            var token = _cookieHelper.Get(CookieTypes.like, Request);
            var products= LikeHelper.GetMethods.Get(token);
            var product = products.LikeProducts.FirstOrDefault(p => p.ProductId == Id);
            if (product.Quantity==1)
            {
                products.LikeProducts.Remove(product);
            }
            else
            {
                product.Quantity += -1;
            }
            return Redirect("/mylike");
        }
        public IActionResult Plus(int Id)
        {
            var token = _cookieHelper.Get(CookieTypes.like, Request);
            var products = LikeHelper.GetMethods.Get(token);
            var product = products.LikeProducts.FirstOrDefault(p => p.ProductId == Id);

            product.Quantity += 1;

            return Redirect("/mylike");
        }

        public IActionResult RemoveProduct(int Id)
        {
            var token = _cookieHelper.Get(CookieTypes.like, Request);
            var products = LikeHelper.GetMethods.Get(token);
            var product = products.LikeProducts.FirstOrDefault(p => p.ProductId == Id);

            products.LikeProducts.Remove(product);

            return Redirect("/mylike");
        }
    }
}
