using ETrade.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETrade.Presentation.Models
{
    // bu class sayesinde Component içerisine aynı anda 1 adet data göndereceğiz. RecentlyViewed
    public class ProductMostViewModel
    {
        public List<ProductImagesCustomModel> MostView { get; set; }
    }
}
