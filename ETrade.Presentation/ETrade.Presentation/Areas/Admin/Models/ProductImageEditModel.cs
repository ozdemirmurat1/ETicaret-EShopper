using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ETrade.Presentation.Areas.Admin.Models
{
    public class ProductImageEditModel
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Name Gereklidir.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Sort Gereklidir.")]
        public int Sort { get; set; }
        public bool? Status { get; set; }
        public string AltText { get; set; }
    }
}
