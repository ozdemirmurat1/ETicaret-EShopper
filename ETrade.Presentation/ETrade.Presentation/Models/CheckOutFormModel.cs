using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ETrade.Presentation.Models
{
    public class CheckOutFormModel
    {

        // Database'deki order tablosuna göre yapıyoruz.

        [Required(ErrorMessage ="Şehir Seçiniz.")]
        public string City { get; set; }
        [Required(ErrorMessage = "Ad Giriniz.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Soyad Seçiniz.")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Telefon Seçiniz.")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Adres Seçiniz.")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Email Giriniz")]
        public string Email { get; set; }
    }
}
