using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplicationAutontific1.Models
{
    public class LoginModel
    {
        [Display(Name = "Логин")]
        [Required]
        public string Name { get; set; }
        [Display(Name = "Пароль")]
        public string Password { get; set; }
    }


    public class RegisterModel
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
    }
}