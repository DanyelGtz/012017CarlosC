using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LoDesbloqueo.Data
{
    [Table("OrdenServServicio")]
    public class OrdenServicioServicio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        [Required(ErrorMessage ="La orden de servicio es requerida")]
        public long? IdOrdenServicio { get; set; }
        [Required(ErrorMessage = "El Servicio es requerido")]
        public long? IdServicio { get; set; }
        [Required(ErrorMessage = "El Estado del Servicio es requerido")]
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
