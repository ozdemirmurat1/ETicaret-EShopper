using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ETrade.Presentation.Areas.Admin.Models
{
    public class SliderModel
    {
        [Required(ErrorMessage = "Image Gereklidir")]
        public IFormFile Image { get; set; }
        public string Header { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        public DateTime? EndDate { get; set; }
        [Required(ErrorMessage = "Status Gereklidir")]
        public bool Status { get; set; }
        [Required(ErrorMessage = "Sort Gereklidir")]
        public int Sort { get; set; }
    }
}
