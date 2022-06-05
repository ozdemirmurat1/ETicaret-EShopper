using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ETrade.Presentation.Areas.Admin.Models
{
    public class UserAddEditModel
    {
        public string UserId { get; set; } // editlenen kullanıcının Id si bilinmelidir.
        [Required(ErrorMessage = "Firstname Giriniz")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Lastname Giriniz")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Cinsiyet gereklidir")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Email Giriniz")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password Giriniz")]
        public string Password { get; set; }
        public bool Status { get; set; }
        public bool IsAdmin { get; set; }
    }
}
