﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LoComercio.Data
{
    [Table("EdoNotificacion")]
    public class EstadoNotificacion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        public string Nombre { get; set; }
    }
}
