using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LoDesbloqueo.Data
{
    [Table("Notificacion")]
    public class Notificacion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public long? IdOrdenServicio { get; set; }
        public long? IdTipoNotificacion { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        public DateTime Fecha { get; set; }
        [Display(Name = "Notificación Activa")]
        public bool NotificacionActiva { get; set; }

        [ForeignKey("IdOrdenServicio")]
        public OrdenServicio OrdenServicio { get; set; }

        [ForeignKey("IdTipoNotificacion")]
        public TipoNotificacion TipoNotificacion { get; set; }

    }
}
