using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ETrade.Presentation.Areas.Admin.Models
{
    public class CategoriesModel
    {
        [Required(ErrorMessage = "Name Gereklidir")]
        public string Name { get; set; }
        [Required(ErrorMessage = "ParentId Gereklidir")]
        public int ParentId { get; set; }
        [Required(ErrorMessage = "Sort Gereklidir")]
        public int Sort { get; set; }
        public bool Status { get; set; }
        [Required(ErrorMessage = "SeoName Gereklidir")]
        public string SeoName { get; set; }       
        public IFormFile Image { get; set; }
    }
}
