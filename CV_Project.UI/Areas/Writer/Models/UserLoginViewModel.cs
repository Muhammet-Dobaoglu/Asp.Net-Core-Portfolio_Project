using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace CV_Project.UI.Areas.Writer.Models
{
    public class UserLoginViewModel
    {
        [Display(Name ="Kullanıcı Adı")]
        [Required(ErrorMessage ="Kullanıcı Adı Giriniz...!")]
        public string Username { get; set; }

        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Şifrenizi Giriniz...")]
        public string Password { get; set; }
    }
}
