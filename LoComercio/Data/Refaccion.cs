﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LoDesbloqueo.Data
{
    [Table("Refaccion")]
    public class Refaccion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        [Display(Name = "Modelo *")]
        public long? IdModelo { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [Display(Name = "Nombre *")]
        public string Nombre { get; set; }

        [Display(Name = "Existencia *")]
        [Required(ErrorMessage = "Campo obligatorio")]
        public int Existencia { get; set; }

        [Display(Name = "Cantidad Mínima *")]
        [Required(ErrorMessage = "Campo obligatorio")]
        public int CantMin { get; set; }

        [Display(Name = "Cantidad Máxima *")]
        [Required(ErrorMessage = "Campo obligatorio")]
        public int CantMax { get; set; }

        [Display(Name = "Modelo *")]
        [ForeignKey("IdModelo")]
        public Modelo Modelo { get; set; }

    }
}
