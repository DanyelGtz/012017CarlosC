using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LoDesbloqueo.Data
{
    [Table("OrdenServicio")]
    public class OrdenServicio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public long? IdCliente { get; set; }
        public long? IdLugarAlmacenamiento { get; set; }
        public long? IdPago { get; set; }
        public long? IdMarca { get; set; }
        public long? IdTipoServicio { get; set; }
        public long? IdModelo { get; set; }
        public long? IdEdoDispositivo { get; set; }
        public long? IdSolRefaccion { get; set; }
        public long? IdSolAccesorio { get; set; }
        public long? IdPersonalEntrega { get; set; }

        //[Required(ErrorMessage = "Campo obligatorio")]
        public string IMEI { get; set; }
        [Display(Name = "Descripción de la Falla")]
        //[Required(ErrorMessage = "Campo obligatorio")]
        public string DescripcionFalla { get; set; }
        [Display(Name = "Deja Accesorios?")]
        public bool DejaAccesorios { get; set; }
        [Display(Name = "Descripción de Accesorios")]
        public string DescripcionAccesorios { get; set; }
        [Display(Name = "Color de Pieza")]
        public string ColorPieza { get; set; }
        [Display(Name = "Compañía Origen")]
        //[Required(ErrorMessage = "Campo obligatorio")]
        public string CompanyaOrigen { get; set; }
        [Display(Name = "Patrón de Desbloqueo")]
        public string PatronDesbloqueo { get; set; }
        [Display(Name = "Password de Desbloqueo")]
        public string PasswordDesbloqueo { get; set; }
        [Display(Name = "Desactivó ICloud?")]
        public bool DesactivoICloud { get; set; }
        [Display(Name = "Reparado Anteriormente?")]
        public bool ReparadoAnteriormente { get; set; }
        [Display(Name = "Descripción de las Reparaciones")]
        public string NotasReparaciones { get; set; }
        [Display(Name = "Equipo Mojado?")]
        public bool EquipoMojado { get; set; }
        [Display(Name = "Equipo Apagado?")]
        public bool EquipoApagado { get; set; }
        [Display(Name = "Revisión Adicional?")]
        public bool RevisionAdicional { get; set; }
        [Display(Name = "Descripción de Revisión Adicional")]
        public string DescripcionRevisionAdicional { get; set; }
        [Display(Name = "Implica Riesgo?")]
        public bool ImplicaRiesgo { get; set; }
        [Display(Name = "Acepta Riesgo?")]
        public bool AceptaRiesgo { get; set; }
        [Display(Name = "Fecha de Llegada")]
        //[Required(ErrorMessage = "Campo obligatorio")]
        public DateTime FechaLlegada { get; set; }
        [Display(Name = "Fecha Posible de Salida")]
        //[Required(ErrorMessage = "Campo obligatorio")]
        public DateTime FechaPosibleSalida { get; set; }
        [Display(Name = "Fecha de Salida")]
        public DateTime FechaSalida { get; set; }
        [Display(Name = "Usuario que Recibe")]
        //[Required(ErrorMessage = "Campo obligatorio")]
        public string UsuarioRecibe { get; set; }
        public string Observaciones { get; set; }

        [ForeignKey("IdCliente")]
        public Cliente Cliente { get; set; }
        
        [ForeignKey("IdLugarAlmacenamiento")]
        public LugarAlmacenamiento LugarAlmacenamiento { get; set; }
        [ForeignKey("IdPago")]
        public Pago Pago { get; set; }
        [ForeignKey("IdModelo")]
        public Modelo Modelo { get; set; }
        [ForeignKey("IdTipoServicio")]
        public TipoServicio TipoServicio { get; set; }
        [ForeignKey("IdMarca")]
        public Marca Marca { get; set; }
        [ForeignKey("IdEdoDispositivo")]
        public EstadoDispositivo EstadoDispositivo { get; set; }
        [ForeignKey("IdSolRefaccion")]
        public SolicitudRefaccion SolicitudRefaccion { get; set; }
        [ForeignKey("IdSolAccesorio")]
        public SolicitudAccesorio SolicitudAccesorio { get; set; }
        
    }
}
