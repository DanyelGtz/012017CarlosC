using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LoComercio.Data
{
    [Table("Modelo")]
    public class Modelo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public long? IdMarca { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        public string Nombre { get; set; }
        [Display(Name = "Modelo Comercial")]
        [Required(ErrorMessage = "Campo obligatorio")]
        public string ModeloComercial { get; set; }

        [ForeignKey("IdMarca")]
        public Marca Marca { get; set; }
    }
}
