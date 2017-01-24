using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LoDesbloqueo.Data
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        public string Nombre { get; set; }
        public string RFC { get; set; }
        [Display(Name = "e-Mail")]
        [EmailAddress]
        public string Email { get; set; }
        [Display(Name = "Teléfono Actual")]
        [Required(ErrorMessage = "Campo obligatorio")]
        public string TelefonoActual { get; set; }
        [Display(Name = "Teléfono de Contacto")]
        [Required(ErrorMessage = "Campo obligatorio")]
        public string TelefonoContacto { get; set; }
        public bool WhatssApp { get; set; }
        public bool WhatssApp2 { get; set; }

        public string Calle { get; set; }
        public string NumInt { get; set; }
        public string NumExt { get; set; }
        public string Colonia { get; set; }
        public string Estado { get; set; }
        [Display(Name = "Hora de Contacto *")]
        [Required (ErrorMessage ="La Hora de Contacto es Requerida")]
        public string HoraContacto { get; set; } 
    }
}
