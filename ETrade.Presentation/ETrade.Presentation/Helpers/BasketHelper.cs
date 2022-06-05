using ETrade.Presentation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETrade.Presentation.Helpers
{
    // BasketHelper ekleme,silme güncelleme yapacak.
    public class BasketHelper
    {
        // Singleton Design Pattern kullanıcaz. 
        // Bir nesnenin uygulama yaşam döngüsü boyunca sadece bir defa örneklenmesini sağlayan pattern'dir.

        private static BasketHelper obj = new BasketHelper();
        public static BasketHelper GetMethods
        {
            get { return obj;  }
        }
        public void Create(BasketModel basketItem) => Program.BasketProductList.Add(basketItem);
        public void RemoveItem(BasketModel basketItem) => Program.BasketProductList.Remove(basketItem);

        public void AddProduct(BasketProduct product,string cookieCode,int userId,int quantity)
        {
            var basket = Program.BasketProductList.Where(x => x.CookieCode == cookieCode).FirstOrDefault();
            if (basket==null)
            {
                var newBasket = new BasketModel()
                {
                   CookieCode=cookieCode,
                   UserId=userId
                };
                newBasket.BasketProducts.Add(product);
                Create(newBasket);
            }
            else
            {
                if (basket.BasketProducts.Any(x=>x.ProductId==product.ProductId))
                {
                    var basketProduct = basket.BasketProducts.FirstOrDefault(x => x.ProductId == product.ProductId);
                    basketProduct.Quantity += quantity;
                }
                else
                {
                    basket.BasketProducts.Add(product);
                }
            }
        }

        public void ReduceProduct(BasketProduct product,string cookieCode,int userId,int quantity)
        {
            var basket = Program.BasketProductList.Where(x => x.CookieCode == cookieCode).FirstOrDefault();

            if (basket.BasketProducts.Any(x=>x.ProductId==product.ProductId))
            {
                var basketProduct = basket.BasketProducts.FirstOrDefault(x => x.ProductId == product.ProductId);
                if (basketProduct.Quantity==1)
                {
                    basket.BasketProducts.Remove(basketProduct);
                }
                else
                {
                    basketProduct.Quantity += -1;
                }
            }
        }

        public BasketModel Get(string code)
        {
            return Program.BasketProductList.Where(x => x.CookieCode == code).FirstOrDefault();
        }

        public Tuple<int,decimal> GetBasketDetails(string code)
        {
            try
            {
                var basket = Get(code);
                if (basket == null)
                {
                    return null;
                }
                Tuple<int, decimal> result;

                int count = basket.BasketProducts.Sum(x => x.Quantity);
                decimal total = basket.BasketProducts.Sum(x => x.Quantity * x.Product.Price);
                return result = new Tuple<int, decimal>(count, total);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
