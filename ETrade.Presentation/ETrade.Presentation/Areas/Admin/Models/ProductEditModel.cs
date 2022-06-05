using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETrade.Presentation.Areas.Admin.Models
{
    public class ProductEditModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public decimal Price { get; set; }
        
        public string Description { get; set; }
        public bool? Status { get; set; }
        public string SeoName { get; set; }
        public int? Counter { get; set; }
    }
}
