﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LoDesbloqueo.Data
{
    [Table("Modelo")]
    public class Modelo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        [Display(Name = "Marca")]
        public long? IdMarca { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        public string Nombre { get; set; }
        [Display(Name = "Modelo Tecnico")]
        [Required(ErrorMessage = "Campo obligatorio")]
        public string ModeloTecnico { get; set; }

        [ForeignKey("IdMarca")]
        public Marca Marca { get; set; }
    }
}
