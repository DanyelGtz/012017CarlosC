using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LoDesbloqueo.Data
{
    [Table("SolAccesorio")]
    public class SolicitudAccesorio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public long? IdAccesorio { get; set; }
        public long? IdEdoAccesorio { get; set; }
        public long? IdUsuario { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        public DateTime Fecha { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        public int Cantidad { get; set; }

        [ForeignKey("IdAccesorio")]
        public Accesorio Accesorio { get; set; }

        [ForeignKey("IdEdoAccesorio")]
        public EstadoAccesorio EstadoAccesorio { get; set; }
        
    }
}
