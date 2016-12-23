using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LoComercio.Models.AccountViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "El Email es requerido")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "El Password es requerido")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Mantener Sesión Abierta")]
        public bool RememberMe { get; set; }
    }
}
