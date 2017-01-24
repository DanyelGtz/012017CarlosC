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
        [Display(Name = "Tipo de Técnico *")]
        public long? IdTipoTecnico { get; set; }

        [Display(Name = "Nombre *")]
        [Required(ErrorMessage = "Campo obligatorio")]
        public string Nombre { get; set; }

        [Display(Name = "Email *")]
        [Required(ErrorMessage ="Campo obligatorio")]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Tipo de Técnico *")]
        [ForeignKey("IdTipoTecnico")]
        public TipoTecnico TipoTecnico { get; set; }
    }
}
