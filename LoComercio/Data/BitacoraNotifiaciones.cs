using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LoComercio.Data
{
    [Table("BitacoraNotificaciones")]
    public class BitacoraNotifiaciones
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public long? IdTipoCambio { get; set; }
        public long? IdUsuario { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        public DateTime Fecha { get; set; }
        [Display(Name = "Descripción")]
        [Required(ErrorMessage = "Campo obligatorio")]
        public string Descripcion { get; set; }
        [Display(Name = "Observación")]
        [Required(ErrorMessage = "Campo obligatorio")]
        public string Observacion { get; set; }

        [ForeignKey("IdTipoCambio")]
        public TipoCambio TipoCambio { get; set; }
        
    }
}
