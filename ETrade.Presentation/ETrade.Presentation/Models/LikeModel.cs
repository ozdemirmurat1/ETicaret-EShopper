using ETrade.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETrade.Presentation.Models
{
    public class LikeModel
    {
        public LikeModel()
        {
            LikeProducts = new List<LikeProduct>();
        }
        public int? UserId { get; set; }  // kullanıcı login olmadan beğenmeli
        public string CookieCode { get; set; }
        public List<LikeProduct> LikeProducts { get; set; }
    }

    public class LikeProduct
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public string Image { get; set; }
    }
}
