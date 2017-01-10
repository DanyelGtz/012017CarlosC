using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LoDesbloqueo.Data
{
    public class EmpresaTelefonica
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public long Id { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        [Display(Name = "Compañia Telefónica")]
        public string Nombre { get; set; }
    }
}
