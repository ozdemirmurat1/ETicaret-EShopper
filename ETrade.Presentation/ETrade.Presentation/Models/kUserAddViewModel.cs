using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ETrade.Presentation.Models
{
    public class kUserAddViewModel
    {
        public string UserId { get; set; }
        [Required(ErrorMessage ="Lütfen Email Giriniz")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Lütfen İsminizi Giriniz")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Lütfen Soyisminizi Giriniz")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Lütfen Cinsiyetinizi Seçiniz")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Lütfen Password Giriniz")]
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
    }
}
