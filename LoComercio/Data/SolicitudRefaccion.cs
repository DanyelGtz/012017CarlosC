using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LoDesbloqueo.Data
{
    [Table("SolRefaccion")]
    public class SolicitudRefaccion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public long? IdRefaccion { get; set; }
        public long? IdEdoRefaccion { get; set; }
        public long? IdUsuario { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        public DateTime Fecha { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        public int Cantidad { get; set; }

        [ForeignKey("IdRefaccion")]
        public Refaccion Refaccion { get; set; }
        [ForeignKey("IdEdoRefaccion")]
        public EstadoRefaccion EstadoRefaccion { get; set; }
        

    }
}
