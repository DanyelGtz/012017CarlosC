using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LoDesbloqueo.Data
{
    [Table("Accesorio")]
    public class Accesorio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        [StringLength(255)]
        [Required(ErrorMessage = "Campo obligatorio")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        public int Existencia { get; set; }
        [Display(Name ="Cantidad Mínima")]
        [Required(ErrorMessage = "Campo obligatorio")]
        public int CantMin { get; set; }
        [Display(Name = "Cantidad Máxima")]
        [Required(ErrorMessage = "Campo obligatorio")]
        public int CantMax { get; set; }
    }
}
