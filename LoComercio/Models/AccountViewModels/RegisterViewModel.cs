using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LoDesbloqueo.Models.AccountViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "El Email es requerido")]
        [EmailAddress]
        [Display(Name = "E-Mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "El Password es requerido")]
        [StringLength(100, ErrorMessage = "El Password {0} deberá tener al menos {2} y máximo {1} caracteres.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirma tu Password")]
        [Compare("Password", ErrorMessage = "El Password y la Confirmación no Coinciden.")]
        public string ConfirmPassword { get; set; }
    }
}
