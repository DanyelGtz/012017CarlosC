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
        [Display(Name ="Estado del Servicio *")]
        public long? IdEdoServicio { get; set; }

        [Display(Name = "Tecnico *")]
        [Required(ErrorMessage = "El Técnico es requerido")]
        public long? IdTecnico { get; set; }

        public string Observaciones { get; set; }

        [ForeignKey("IdTecnico")]
        [Display(Name = "Tecnico *")]
        public Tecnico Tecnico { get; set; }

        [ForeignKey("IdServicio")]
        [Display(Name = "Servicio *")]
        public Servicio Servicio { get; set; }

        [ForeignKey("IdOrdenServicio")]
        [Display(Name = "Orden de Servicio *")]
        public OrdenServicio OrdenServicio { get; set; }

        [ForeignKey("IdEdoServicio")]
        [Display(Name = "Estado del Servicio *")]
        public EstadoServicio EstadoServicio { get; set; }
        public float PrecioServicio { get; set; }
    }
}
