using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoDesbloqueo.Data;
using Microsoft.EntityFrameworkCore;
using LoDesbloqueo.Models;


namespace LoDesbloqueo.Data
{
    public partial class ApplicationDbContext
    {
        public void EnsureSeedData()
        {
            if (this.AllMigrationsApplied())
            {
                EnsureSeedEstadoAccesorio();
                EnsureSeedEstadoRefaccion();
                EnsureSeedEstadoDispositivo();
                EnsureSeedEstadoServicio();
                EnsureSeedEstadoNotificacion();
                EnsureSeedTipoTecnico();
                EnsureSeedFormaDePago();
                EnsureSeedTipoServicio();
                EnsureSeedEmpresasTelefonicas();
                EnsureSeedMarcas();
                EnsureSeedModelos();
                EnsureSeedLugaresAlmacenamiento();
            }
        }
        private void EnsureSeedMarcas()
        {
            if (!Marcas.Any())
            {
                Marcas.AddRange(
                    new Marca { Id = 1, Nombre = "NOKIA" },
                    new Marca { Id = 2, Nombre = "LG" },
                    new Marca { Id = 3, Nombre = "SAMSUNG" },
                    new Marca { Id = 4, Nombre = "HUAWEI" },
                    new Marca { Id = 5, Nombre = "MOTOROLA" },
                    new Marca { Id = 6, Nombre = "HTC" },
                    new Marca { Id = 7, Nombre = "APPLE" },
                    new Marca { Id = 8, Nombre = "BLACKBERRY" },
                    new Marca { Id = 9, Nombre = "SONY" },
                    new Marca { Id = 10, Nombre = "LENOVO" },
                    new Marca { Id = 11, Nombre = "XIAOMI" },
                    new Marca { Id = 12, Nombre = "ZTE" },
                    new Marca { Id = 13, Nombre = "LANIX" },
                    new Marca { Id = 14, Nombre = "OPPO" },
                    new Marca { Id = 15, Nombre = "MEIZU" },
                    new Marca { Id = 16, Nombre = "AZUS" },
                    new Marca { Id = 17, Nombre = "ALCATEL" },
                    new Marca { Id = 18, Nombre = "SKY" },
                    new Marca { Id = 19, Nombre = "BLU" },
                    new Marca { Id = 20, Nombre = "PANTECH" },
                    new Marca { Id = 21, Nombre = "KIOCERA" },
                    new Marca { Id = 22, Nombre = "M4TEL" }
                );

                SaveChanges();
            }
        }
        private void EnsureSeedLugaresAlmacenamiento()
        {
            if (!LugaresAlmacenamiento.Any())
            {
                LugaresAlmacenamiento.AddRange(
                    new LugarAlmacenamiento { Id = 1, Nombre = "S-120" },
                    new LugarAlmacenamiento { Id = 2, Nombre = "W-220" },
                    new LugarAlmacenamiento { Id = 3, Nombre = "T-120" }
                );

                SaveChanges();
            }
        }

        private void EnsureSeedModelos()
        {
            if (!Modelos.Any())
            {
                Modelos.AddRange(
                    new Modelo { IdMarca=1, ModeloTecnico="T-440S", Nombre = "S5" },
                    new Modelo { IdMarca = 1, ModeloTecnico = "T-440T", Nombre = "S5" },
                    new Modelo { IdMarca = 1, ModeloTecnico = "T-550S", Nombre = "S6" }
                );

                SaveChanges();
            }
        }
        private void EnsureSeedTipoServicio()
        {
            if (!TiposServicio.Any())
            {
                TiposServicio.AddRange(
                    new TipoServicio { Id = 1, Nombre = "Reparación" },
                    new TipoServicio { Id = 2, Nombre = "Liberación" },
                    new TipoServicio { Id = 3, Nombre = "Reparación MicroComponente" },
                    new TipoServicio { Id = 4, Nombre = "Software" },
                    new TipoServicio { Id = 5, Nombre = "Garantía" },
                    new TipoServicio { Id = 6, Nombre = "Garantía Válida" }
                );

                SaveChanges();
            }
        }

        private void EnsureSeedFormaDePago()
        {
            if (!FormasPagos.Any())
            {
                FormasPagos.AddRange(
                    new FormaPago { Id = 1, Nombre = "Efectivo" },
                    new FormaPago { Id = 2, Nombre = "Tarjeta de Débito/Crédito" }
                );

                SaveChanges();
            }
        }

        private void EnsureSeedEstadoNotificacion()
        {
            if (!EstadosNotificaciones.Any())
            {
                EstadosNotificaciones.AddRange(
                    new EstadoNotificacion { Id = 1, Nombre = "Activa" },
                    new EstadoNotificacion { Id = 2, Nombre = "Inactiva" }
                );

                SaveChanges();
            }

        }

        private void EnsureSeedEstadoDispositivo()
        {
            if (!EstadosDispositivos.Any())
            {
                EstadosDispositivos.AddRange(
                    new EstadoDispositivo { Id = 1, Nombre = "Ingresando (Dar Entrada)" },
                    new EstadoDispositivo { Id = 2, Nombre = "En Proceso" },
                    new EstadoDispositivo { Id = 3, Nombre = "Finalizado" },
                    new EstadoDispositivo { Id = 4, Nombre = "Notificado" },
                    new EstadoDispositivo { Id = 5, Nombre = "No Notificado" },
                    new EstadoDispositivo { Id = 6, Nombre = "Entregado" }
                );

                SaveChanges();
            }
        }

        private void EnsureSeedEstadoServicio()
        {
            if (!EstadosServicios.Any())
            {
                EstadosServicios.AddRange(
                    new EstadoServicio { Id = 1, Nombre = "En Espera" },
                    new EstadoServicio { Id = 2, Nombre = "En Proceso" },
                    new EstadoServicio { Id = 3, Nombre = "Completado" },
                    new EstadoServicio { Id = 4, Nombre = "Completado Parcialmente" },
                    new EstadoServicio { Id = 5, Nombre = "No Completado" }
                );
                SaveChanges();
            }
        }

        private void EnsureSeedEstadoAccesorio()
        {
            if (!EstadosAccesorios.Any())
            {
                EstadosAccesorios.AddRange(
                    new EstadoAccesorio { Id = 1, Nombre = "Instalado" },
                    new EstadoAccesorio { Id = 2, Nombre = "No Instalado" },
                    new EstadoAccesorio { Id = 3, Nombre = "Esperando Autorizacion" },
                    new EstadoAccesorio { Id = 4, Nombre = "Autorizado" }
                );

                SaveChanges();
            }
        }

        private void EnsureSeedEstadoRefaccion()
        {
            if (!EstadosRefacciones.Any())
            {
                EstadosRefacciones.AddRange(
                    new EstadoRefaccion { Id = 1, Nombre = "Instalado" },
                    new EstadoRefaccion { Id = 2, Nombre = "No Instalado" },
                    new EstadoRefaccion { Id = 3, Nombre = "Esperando Autorizacion" },
                    new EstadoRefaccion { Id = 4, Nombre = "Autorizado" }
                );

                SaveChanges();
            }
        }

        private void EnsureSeedTipoTecnico()
        {
            if (!TiposTecnico.Any())
            {
                TiposTecnico.AddRange(
                    new TipoTecnico { Id = 1, Nombre = "TECNICO DE REPARACION" },
                    new TipoTecnico { Id = 2, Nombre = "TECNICO DE LIBERACION" },
                    new TipoTecnico { Id = 3, Nombre = "TECNICO DE MICROCOMPONENTE" }
                );
                SaveChanges();
            }
        }

        private void EnsureSeedEmpresasTelefonicas()
        {
            if (!EmpresasTelefonicas.Any())
            {
                EmpresasTelefonicas.AddRange(
                    new EmpresaTelefonica { Id = 1, Nombre = "Telcel" },
                    new EmpresaTelefonica { Id = 2, Nombre = "Movistar" },
                    new EmpresaTelefonica { Id = 3, Nombre = "At&t" },
                    new EmpresaTelefonica { Id = 4, Nombre = "Nextel" },
                    new EmpresaTelefonica { Id = 5, Nombre = "Iusacell" }
                );
                SaveChanges();
            }
        }

        public DbSet<ApplicationUser> ApplicationUser { get; set; }
    }
}
