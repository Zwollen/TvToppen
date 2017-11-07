using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TVtoppen.Models.ViewModels
{
    public class LoginVM
    {
        [Required(ErrorMessage = "Du behöver fylla i Användarnamn")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Du behöver fylla i Lösenord")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}