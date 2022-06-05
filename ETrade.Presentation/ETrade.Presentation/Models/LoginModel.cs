using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ETrade.Presentation.Models
{
    public class LoginModel
    {       
        [Required(ErrorMessage ="Email Boş Bırakılamaz."),MaxLength(30,ErrorMessage ="30 Karakterden Uzun Email Olamaz.")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^(([^<>()[\]\\.,;:\s@""]+(\.[^<>()[\]\\.,;:\s@""]+)*)|("".+""))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$", ErrorMessage = "Hatalı Email")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Şifre Mutlaka Girilmelidir.")]
        public string Password { get; set; }
        public bool ısDeleted { get; set; }

    }
}
