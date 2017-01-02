using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LoComercio.Data
{
    [Table("OrdenServServicio")]
    public class OrdenServicioServicio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public long? IdOrdenServicio { get; set; }
        public long? IdServicio { get; set; }
        public long? IdEdoServicio { get; set; }

        [ForeignKey("IdServicio")]
        public Servicio Servicio { get; set; }
        [ForeignKey("IdOrdenServicio")]
        public OrdenServicio OrdenServicio { get; set; }

        [ForeignKey("IdEdoServicio")]
        public EstadoServicio EstadoServicio { get; set; }
        public float PrecioServicio { get; set; }
    }
}
