using ETrade.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETrade.Presentation.Areas.Admin.Models
{
    public class ProductListViewModel
    {
        public List<Product> Products { get; set; }
        public List<ProductImage> ProductImages { get; set; }
    }
}
