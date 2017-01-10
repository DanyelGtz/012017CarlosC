using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoDesbloqueo.Data;
using Microsoft.EntityFrameworkCore;


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
                    new EstadoDispositivo { Id = 1, Nombre = "Dar Entrada" },
                    new EstadoDispositivo { Id = 2, Nombre = "En Proceso" },
                    new EstadoDispositivo { Id = 3, Nombre = "Finalizado Exitosamente" },
                    new EstadoDispositivo { Id = 4, Nombre = "Finalizado Parcialmente" },
                    new EstadoDispositivo { Id = 5, Nombre = "No Completado" }
                );

                SaveChanges();
            }
        }

        private void EnsureSeedEstadoServicio()
        {
            if (!EstadosServicios.Any())
            {
                EstadosServicios.AddRange(
                    new EstadoServicio { Id = 1, Nombre = "Entregado" },
                    new EstadoServicio { Id = 2, Nombre = "No Entregado" },
                    new EstadoServicio { Id = 3, Nombre = "Notificado" },
                    new EstadoServicio { Id = 4, Nombre = "No Notificado" },
                    new EstadoServicio { Id = 5, Nombre = "No Encontrado, Comunicarse mas Tarde" }
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
                    new EstadoAccesorio { Id = 2, Nombre = "No Instalado" }
                );

                SaveChanges();
            }
        }

        private void EnsureSeedEstadoRefaccion()
        {
            if (!EstadosRefacciones.Any())
            {
                EstadosRefacciones.AddRange(
                    new EstadoRefaccion { Id = 1, Nombre = "Instalada" },
                    new EstadoRefaccion { Id = 2, Nombre = "En Espera de Autorizacion" },
                    new EstadoRefaccion { Id = 3, Nombre = "Autorizada" },
                    new EstadoRefaccion { Id = 4, Nombre = "No Autorizada" },
                    new EstadoRefaccion { Id = 5, Nombre = "No Instalada" }
                );

                SaveChanges();
            }
        }

        private void EnsureSeedTipoTecnico()
        {
            if (!TiposTecnico.Any())
            {
                TiposTecnico.AddRange(
                    new TipoTecnico { Id = 1, Nombre = "De Reparaciones" },
                    new TipoTecnico { Id = 2, Nombre = "De Liberaciones" },
                    new TipoTecnico { Id = 3, Nombre = "De MicroComponentes" }
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
    }
}
