using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoDesbloqueo.Models.AccountViewModels
{
    public class ModificarRolViewModel
    {
        public string Email { get; set; }
        public string Rol { get; set; }
        
        public List<string> ListaRoles { get; set; }

    }
}
