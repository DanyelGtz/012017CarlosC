using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LoComercio.Data
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        
        public string RFC { get; set; }
        [Display(Name = "e-Mail")]
        [EmailAddress]
        [Required(ErrorMessage = "Campo obligatorio")]
        public string Email { get; set; }
        [Display(Name = "Teléfono Actual")]
        [Required(ErrorMessage = "Campo obligatorio")]
        public string TelefonoActual { get; set; }
        [Display(Name = "Teléfono de Contacto")]
        [Required(ErrorMessage = "Campo obligatorio")]
        public string TelefonoContacto { get; set; }
        public bool WhatssApp { get; set; }
    }
}
