using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ETrade.Presentation.Areas.Admin.Models
{
    public class ProductAddModel
    {
        [Required(ErrorMessage = "İsim Gereklidir.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Fiyat Gereklidir.")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Description Gereklidir.")]
        public string Description { get; set; }
        public bool Status { get; set; }
        public string SeoName { get; set; }
        public int Counter { get; set; }
    }
}
