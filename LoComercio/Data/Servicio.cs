using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LoDesbloqueo.Data
{
    [Table("Servicio")]
    public class Servicio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public long? IdTipoServicio { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        [Display(Name ="Precio Sugerido *")]
        public float PrecioSugerido { get; set; }
        [Display(Name = "Precio Mínimo *")]
        public float PrecioMinimo { get; set; }
        [Display(Name = "Precio Máximo *")]
        public float PrecioMaximo { get; set; }

        [ForeignKey("IdTipoServicio")]
        public TipoServicio TipoServicio { get; set; }
    }
}
