using ETrade.Presentation.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace ETrade.Presentation.Models
{
    public class SliderEditModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Image Gereklidir")]
        public string Image { get; set; }
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
