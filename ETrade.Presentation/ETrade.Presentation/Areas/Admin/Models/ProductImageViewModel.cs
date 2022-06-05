using ETrade.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETrade.Presentation.Areas.Admin.Models
{
    public class ProductImageViewModel
    {
        public List<ProductImage> ProductImages { get; set; }
        public string Name { get; set; }
    }
}
