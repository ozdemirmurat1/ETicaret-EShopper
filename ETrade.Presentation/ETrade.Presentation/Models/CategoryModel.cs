using ETrade.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETrade.Presentation.Models
{
    public class CategoryModel
    {
        public List<Category> CategoriesParentIdZero { get; set; }
        public List<Category> CategoriesParentIdTwo { get; set; }
        public List<Category> CategoriesAll { get; set; }
        public List<Category> CategoriesWithParentId { get; set; }

        public string SelectedCategory { get; set; }

    }
}
