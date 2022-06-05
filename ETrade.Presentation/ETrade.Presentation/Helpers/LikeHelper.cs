using ETrade.Presentation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETrade.Presentation.Helpers
{
    public class LikeHelper
    {
        private static LikeHelper obj = new LikeHelper();

        public static LikeHelper GetMethods
        {
            get { return obj; }
        } 
        public void Create(LikeModel likeItem) => Program.LikeProductList.Add(likeItem);

        public void AddProduct(LikeProduct product,string cookieCode,int userId,int quantity)
        {
            var like = Program.LikeProductList.Where(x => x.CookieCode == cookieCode).FirstOrDefault();
            if (like==null)
            {
                var newLike = new LikeModel()
                {
                    CookieCode=cookieCode,
                    UserId=userId
                };
                newLike.LikeProducts.Add(product);
                Create(newLike);
            }
            else
            {
                if (like.LikeProducts.Any(x=>x.ProductId==product.ProductId))
                {
                    var likeProduct = like.LikeProducts.FirstOrDefault(x => x.ProductId == product.ProductId);
                    likeProduct.Quantity += quantity;
                }
                else
                {
                    like.LikeProducts.Add(product);
                }
            }
        }

        public LikeModel Get(string code)
        {
            return Program.LikeProductList.Where(x => x.CookieCode == code).FirstOrDefault();
        }

        public string GetLikeDetails(string code)
        {
            try
            {
                var like = Get(code);
                if (like==null)
                {
                    return null;
                }

                int count = like.LikeProducts.Sum(x => x.Quantity);
                //decimal total = like.LikeProducts.Sum(x => x.Quantity * x.Product.Price);
                return count.ToString();
            }
            catch (Exception)
            {
                return null;
            }
        }
        
    }
}
