using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LoComercio.Data
{
    [Table("Pago")]
    public class Pago
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public long? IdFormaPago { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        public DateTime Fecha { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        public float Monto { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        public float Anticipo { get; set; }

        [ForeignKey("IdFormaPago")]
        public FormaPago FormaPago { get; set; }
    }
}
