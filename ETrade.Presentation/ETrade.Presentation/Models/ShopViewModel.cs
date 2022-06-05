using ETrade.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETrade.Presentation.Models
{
    public class ShopViewModel
    {
        public List<CategoryProductsCustomModel> Products { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPage { get; set; }
        public string CategoryName { get; set; }
    }
}
