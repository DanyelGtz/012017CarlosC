using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LoDesbloqueo.Data
{
    [Table("Tecnico")]
    public class Tecnico
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        
        public long? IdTipoTecnico { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        public string Nombre { get; set; }

        [ForeignKey("IdTipoTecnico")]
        public TipoTecnico TipoTecnico { get; set; }
    }
}
