using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using LoDesbloqueo.Models;

namespace LoDesbloqueo.Data
{
    public partial class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Accesorio> Accesorios { get; set; }
        public DbSet<BitacoraEstados> BitacoraEstados { get; set; }
        public DbSet<BitacoraNotifiaciones> BitacoraNotificaciones { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<EmpresaTelefonica> EmpresasTelefonicas { get; set; }
        public DbSet<EstadoAccesorio> EstadosAccesorios { get; set;}
        public DbSet<EstadoDispositivo> EstadosDispositivos { get; set; }
        public DbSet<EstadoNotificacion> EstadosNotificaciones { get; set; }
        public DbSet<EstadoRefaccion> EstadosRefacciones { get; set; }
        public DbSet<EstadoServicio> EstadosServicios { get; set; }
        public DbSet<FormaPago> FormasPagos { get; set; }
        public DbSet<LugarAlmacenamiento> LugaresAlmacenamiento { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Modelo> Modelos { get; set; }
        public DbSet<Notificacion> Notificaciones { get; set; }
        public DbSet<OrdenServicio> OrdenesServicio { get; set; }
        public DbSet<OrdenServicioServicio> OrdenesServicioServicio { get; set; }
        public DbSet<Pago> Pagos { get; set; }
        public DbSet<Refaccion> Refacciones { get; set; }
        public DbSet<Servicio> Servicios { get; set; }
        public DbSet<SolicitudAccesorio> SolicitudAccesorios { get; set; }
        public DbSet<SolicitudRefaccion> SolicitudRefacciones { get; set; }
        public DbSet<Tecnico> Tecnicos { get; set; }
        public DbSet<TipoCambio> TiposCambio { get; set; }
        public DbSet<TipoNotificacion> TiposNotificaciones { get; set; }
        public DbSet<TipoServicio> TiposServicio { get; set; }
        public DbSet<TipoTecnico> TiposTecnico { get; set; }
        


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }

        public ApplicationDbContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            

        }

        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {

            //optionsBuilder.UseMySql(Configuration.GetConnectionString("MySQLConnection"));
        }
    }
}
