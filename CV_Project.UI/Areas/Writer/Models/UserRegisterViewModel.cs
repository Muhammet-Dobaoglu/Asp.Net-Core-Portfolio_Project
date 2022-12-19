using System.ComponentModel.DataAnnotations;

namespace CV_Project.UI.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage ="Lütfen Adını Giriniz ")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen Soyadınızı Giriniz ")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Lütfen Kullanıcı Adını Giriniz ")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen Görsel Yükleyiniz ")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "Lütfen Parolanızı Giriniz ")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen Parolanızı Tekrar Giriniz")]
        [Compare("Password",ErrorMessage ="Girdiğiniz Parolalar Uyumlu Değil!")]
        public string ComfirmPassword { get; set; }

        [Required(ErrorMessage = "Lütfen Mail Adresinizi Giriniz ")]
        public string Mail { get; set; }
    }
}
