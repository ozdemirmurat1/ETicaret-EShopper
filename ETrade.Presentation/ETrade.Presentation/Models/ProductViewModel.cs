using ETrade.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETrade.Presentation.Models
{
    public class ProductViewModel
    {
        public Product ProductDetail { get; set; }
        public List<ProductImage> Images{ get; set; }
        public List<Product> Products{ get; set; }
        public List<ProductImagesCustomModel> LastViews { get; set; }
        public ReviewViewModel Reviews { get; set; }
        
        
       

    }
}
