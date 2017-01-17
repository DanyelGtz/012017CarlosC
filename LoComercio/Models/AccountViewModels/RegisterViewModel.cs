using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LoDesbloqueo.Models.AccountViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "El Email es Requerido")]
        [RegularExpression("\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*", ErrorMessage = "El formato aceptado es ejemplo@email.mx ")]
        [EmailAddress(ErrorMessage = "Se espera Email valido: ejemplo@email.mx")]
        [Display(Name = "E-Mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "La Contraseña es Requerida")]
        [StringLength(10, ErrorMessage = "El {0} deberá contener al menos {2} y un máximo de  {1} caracteres.", MinimumLength = 8)]
        [RegularExpression("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*.-]).{8,}$", ErrorMessage = "Debe ingresar una contraseña de 8 a 10 dígitos (Mayúsculas, Minúsculas, Números y un Carácter)")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirma tu Password")]
        [Compare("Password", ErrorMessage = "El Password y la Confirmación no Coinciden.")]
        public string ConfirmPassword { get; set; }
    }
}
