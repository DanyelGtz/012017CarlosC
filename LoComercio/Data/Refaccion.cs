using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LoDesbloqueo.Data
{
    [Table("Refaccion")]
    public class Refaccion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public long? IdModelo { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        public int Existencia { get; set; }

        [Display(Name = "Cantidad Mínima")]
        [Required(ErrorMessage = "Campo obligatorio")]
        public int CantMin { get; set; }

        [Display(Name = "Cantidad Máxima")]
        [Required(ErrorMessage = "Campo obligatorio")]
        public int CantMax { get; set; }

        [ForeignKey("IdModelo")]
        public Modelo Modelo { get; set; }

    }
}
