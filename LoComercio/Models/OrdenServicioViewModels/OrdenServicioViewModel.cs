using LoDesbloqueo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoDesbloqueo.Models.OrdenServicioViewModels
{
    public class OrdenServicioViewModel
    {
        public OrdenServicio OrdenServicio { get; set; }
        public List<OrdenServicioServicio> OrdenServicioServicios { get; set; }
    }
}
