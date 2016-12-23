using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using LoComercio.Data;

namespace LoComercio.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20161222014251_Modelo")]
    partial class Modelo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1");

            modelBuilder.Entity("LoComercio.Data.Accesorio", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CantMax");

                    b.Property<int>("CantMin");

                    b.Property<int>("Existencia");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 255);

                    b.HasKey("Id");

                    b.ToTable("Accesorios");
                });

            modelBuilder.Entity("LoComercio.Data.BitacoraEstados", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descripcion")
                        .IsRequired();

                    b.Property<DateTime>("Fecha");

                    b.Property<long?>("IdTipoCambio");

                    b.Property<long?>("IdUsuario");

                    b.Property<string>("Observacion")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("IdTipoCambio");

                    b.ToTable("BitacoraEstados");
                });

            modelBuilder.Entity("LoComercio.Data.BitacoraNotifiaciones", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descripcion")
                        .IsRequired();

                    b.Property<DateTime>("Fecha");

                    b.Property<long?>("IdTipoCambio");

                    b.Property<long?>("IdUsuario");

                    b.Property<string>("Observacion")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("IdTipoCambio");

                    b.ToTable("BitacoraNotificaciones");
                });

            modelBuilder.Entity("LoComercio.Data.Cliente", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.Property<string>("RFC")
                        .IsRequired();

                    b.Property<string>("TelefonoActual")
                        .IsRequired();

                    b.Property<string>("TelefonoContacto")
                        .IsRequired();

                    b.Property<bool>("WhatssApp");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("LoComercio.Data.EstadoAccesorio", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("EstadosAccesorios");
                });

            modelBuilder.Entity("LoComercio.Data.EstadoDispositivo", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("EstadosDispositivos");
                });

            modelBuilder.Entity("LoComercio.Data.EstadoNotificacion", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("EstadosNotificaciones");
                });

            modelBuilder.Entity("LoComercio.Data.EstadoRefaccion", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("EstadosRefacciones");
                });

            modelBuilder.Entity("LoComercio.Data.EstadoServicio", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("EstadosServicios");
                });

            modelBuilder.Entity("LoComercio.Data.FormaPago", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("FormasPagos");
                });

            modelBuilder.Entity("LoComercio.Data.LugarAlmacenamiento", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("LugaresAlmacenamiento");
                });

            modelBuilder.Entity("LoComercio.Data.Marca", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Marcas");
                });

            modelBuilder.Entity("LoComercio.Data.Modelo", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("IdMarca");

                    b.Property<string>("ModeloComercial")
                        .IsRequired();

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("IdMarca");

                    b.ToTable("Modelos");
                });

            modelBuilder.Entity("LoComercio.Data.Notificacion", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Fecha");

                    b.Property<long?>("IdOrdenServicio");

                    b.Property<long?>("IdTipoNotificacion");

                    b.Property<bool>("NotificacionActiva");

                    b.HasKey("Id");

                    b.HasIndex("IdOrdenServicio");

                    b.HasIndex("IdTipoNotificacion");

                    b.ToTable("Notificaciones");
                });

            modelBuilder.Entity("LoComercio.Data.OrdenServicio", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("AceptaRiesgo");

                    b.Property<string>("ColorDispositivo");

                    b.Property<string>("ColorPieza");

                    b.Property<string>("CompanyaOrigen")
                        .IsRequired();

                    b.Property<bool>("DejaAccesorios");

                    b.Property<bool>("DesactivoICloud");

                    b.Property<string>("DescripcionAccesorios");

                    b.Property<string>("DescripcionFalla")
                        .IsRequired();

                    b.Property<string>("DescripcionRevisionAdicional");

                    b.Property<bool>("EquipoApagado");

                    b.Property<bool>("EquipoMojado");

                    b.Property<DateTime>("FechaLlegada");

                    b.Property<DateTime>("FechaPosibleSalida");

                    b.Property<DateTime>("FechaSalida");

                    b.Property<string>("IMEI")
                        .IsRequired();

                    b.Property<long?>("IdCliente");

                    b.Property<long?>("IdEdoDispositivo");

                    b.Property<long?>("IdEdoNotificacion");

                    b.Property<long?>("IdLugarAlmacenamiento");

                    b.Property<long?>("IdMarca");

                    b.Property<long?>("IdModeloTecnico");

                    b.Property<long?>("IdPago");

                    b.Property<long?>("IdPersonalEntrega");

                    b.Property<long?>("IdSolAccesorio");

                    b.Property<long?>("IdSolRefaccion");

                    b.Property<long?>("IdTecnico");

                    b.Property<bool>("ImplicaRiesgo");

                    b.Property<string>("NotasReparaciones");

                    b.Property<string>("Observaciones");

                    b.Property<string>("PasswordDesbloqueo");

                    b.Property<string>("PatronDesbloqueo");

                    b.Property<bool>("ReparadoAnteriormente");

                    b.Property<bool>("RevisionAdicional");

                    b.Property<string>("UsuarioRecibe")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("IdCliente");

                    b.HasIndex("IdEdoDispositivo");

                    b.HasIndex("IdEdoNotificacion");

                    b.HasIndex("IdLugarAlmacenamiento");

                    b.HasIndex("IdModeloTecnico");

                    b.HasIndex("IdPago");

                    b.HasIndex("IdSolAccesorio");

                    b.HasIndex("IdSolRefaccion");

                    b.HasIndex("IdTecnico");

                    b.ToTable("OrdenesServicio");
                });

            modelBuilder.Entity("LoComercio.Data.OrdenServicioServicio", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("IdEdoServicio");

                    b.Property<long?>("IdServicio");

                    b.HasKey("Id");

                    b.HasIndex("IdEdoServicio");

                    b.HasIndex("IdServicio");

                    b.ToTable("OrdenesServicioServicio");
                });

            modelBuilder.Entity("LoComercio.Data.Pago", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<float>("Anticipo");

                    b.Property<DateTime>("Fecha");

                    b.Property<long?>("IdFormaPago");

                    b.Property<float>("Monto");

                    b.HasKey("Id");

                    b.HasIndex("IdFormaPago");

                    b.ToTable("Pagos");
                });

            modelBuilder.Entity("LoComercio.Data.Refaccion", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CantMax");

                    b.Property<int>("CantMin");

                    b.Property<int>("Existencia");

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Refacciones");
                });

            modelBuilder.Entity("LoComercio.Data.Servicio", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("IdTipoServicio");

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.Property<float>("Precio");

                    b.HasKey("Id");

                    b.HasIndex("IdTipoServicio");

                    b.ToTable("Servicios");
                });

            modelBuilder.Entity("LoComercio.Data.SolicitudAccesorio", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Cantidad");

                    b.Property<DateTime>("Fecha");

                    b.Property<long?>("IdAccesorio");

                    b.Property<long?>("IdEdoAccesorio");

                    b.Property<long?>("IdUsuario");

                    b.HasKey("Id");

                    b.HasIndex("IdAccesorio");

                    b.HasIndex("IdEdoAccesorio");

                    b.ToTable("SolicitudAccesorios");
                });

            modelBuilder.Entity("LoComercio.Data.SolicitudRefaccion", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Cantidad");

                    b.Property<DateTime>("Fecha");

                    b.Property<long?>("IdEdoRefaccion");

                    b.Property<long?>("IdRefaccion");

                    b.Property<long?>("IdUsuario");

                    b.HasKey("Id");

                    b.HasIndex("IdEdoRefaccion");

                    b.HasIndex("IdRefaccion");

                    b.ToTable("SolicitudRefacciones");
                });

            modelBuilder.Entity("LoComercio.Data.Tecnico", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("IdTipoTecnico");

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("IdTipoTecnico");

                    b.ToTable("Tecnicos");
                });

            modelBuilder.Entity("LoComercio.Data.TipoCambio", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("TiposCambio");
                });

            modelBuilder.Entity("LoComercio.Data.TipoNotificacion", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("TiposNotificaciones");
                });

            modelBuilder.Entity("LoComercio.Data.TipoServicio", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("TiposServicio");
                });

            modelBuilder.Entity("LoComercio.Data.TipoTecnico", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("TiposTecnico");
                });

            modelBuilder.Entity("LoComercio.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedUserName")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("LoComercio.Data.BitacoraEstados", b =>
                {
                    b.HasOne("LoComercio.Data.TipoCambio", "TipoCambio")
                        .WithMany()
                        .HasForeignKey("IdTipoCambio");
                });

            modelBuilder.Entity("LoComercio.Data.BitacoraNotifiaciones", b =>
                {
                    b.HasOne("LoComercio.Data.TipoCambio", "TipoCambio")
                        .WithMany()
                        .HasForeignKey("IdTipoCambio");
                });

            modelBuilder.Entity("LoComercio.Data.Modelo", b =>
                {
                    b.HasOne("LoComercio.Data.Modelo", "Marca")
                        .WithMany()
                        .HasForeignKey("IdMarca");
                });

            modelBuilder.Entity("LoComercio.Data.Notificacion", b =>
                {
                    b.HasOne("LoComercio.Data.OrdenServicio", "OrdenServicio")
                        .WithMany()
                        .HasForeignKey("IdOrdenServicio");

                    b.HasOne("LoComercio.Data.TipoNotificacion", "TipoNotificacion")
                        .WithMany()
                        .HasForeignKey("IdTipoNotificacion");
                });

            modelBuilder.Entity("LoComercio.Data.OrdenServicio", b =>
                {
                    b.HasOne("LoComercio.Data.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("IdCliente");

                    b.HasOne("LoComercio.Data.EstadoDispositivo", "EstadoDispositivo")
                        .WithMany()
                        .HasForeignKey("IdEdoDispositivo");

                    b.HasOne("LoComercio.Data.EstadoNotificacion", "EstadoNotificacion")
                        .WithMany()
                        .HasForeignKey("IdEdoNotificacion");

                    b.HasOne("LoComercio.Data.LugarAlmacenamiento", "LugarAlmacenamiento")
                        .WithMany()
                        .HasForeignKey("IdLugarAlmacenamiento");

                    b.HasOne("LoComercio.Data.Modelo", "Modelo")
                        .WithMany()
                        .HasForeignKey("IdModeloTecnico");

                    b.HasOne("LoComercio.Data.Pago", "Pago")
                        .WithMany()
                        .HasForeignKey("IdPago");

                    b.HasOne("LoComercio.Data.SolicitudAccesorio", "SolicitudAccesorio")
                        .WithMany()
                        .HasForeignKey("IdSolAccesorio");

                    b.HasOne("LoComercio.Data.SolicitudRefaccion", "SolicitudRefaccion")
                        .WithMany()
                        .HasForeignKey("IdSolRefaccion");

                    b.HasOne("LoComercio.Data.Tecnico", "Tecnico")
                        .WithMany()
                        .HasForeignKey("IdTecnico");
                });

            modelBuilder.Entity("LoComercio.Data.OrdenServicioServicio", b =>
                {
                    b.HasOne("LoComercio.Data.EstadoServicio", "EstadoServicio")
                        .WithMany()
                        .HasForeignKey("IdEdoServicio");

                    b.HasOne("LoComercio.Data.Servicio", "Servicio")
                        .WithMany()
                        .HasForeignKey("IdServicio");
                });

            modelBuilder.Entity("LoComercio.Data.Pago", b =>
                {
                    b.HasOne("LoComercio.Data.FormaPago", "FormaPago")
                        .WithMany()
                        .HasForeignKey("IdFormaPago");
                });

            modelBuilder.Entity("LoComercio.Data.Servicio", b =>
                {
                    b.HasOne("LoComercio.Data.TipoServicio", "TipoServicio")
                        .WithMany()
                        .HasForeignKey("IdTipoServicio");
                });

            modelBuilder.Entity("LoComercio.Data.SolicitudAccesorio", b =>
                {
                    b.HasOne("LoComercio.Data.Accesorio", "Accesorio")
                        .WithMany()
                        .HasForeignKey("IdAccesorio");

                    b.HasOne("LoComercio.Data.EstadoAccesorio", "EstadoAccesorio")
                        .WithMany()
                        .HasForeignKey("IdEdoAccesorio");
                });

            modelBuilder.Entity("LoComercio.Data.SolicitudRefaccion", b =>
                {
                    b.HasOne("LoComercio.Data.EstadoRefaccion", "EstadoRefaccion")
                        .WithMany()
                        .HasForeignKey("IdEdoRefaccion");

                    b.HasOne("LoComercio.Data.Refaccion", "Refaccion")
                        .WithMany()
                        .HasForeignKey("IdRefaccion");
                });

            modelBuilder.Entity("LoComercio.Data.Tecnico", b =>
                {
                    b.HasOne("LoComercio.Data.TipoTecnico", "TipoTecnico")
                        .WithMany()
                        .HasForeignKey("IdTipoTecnico");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("LoComercio.Models.ApplicationUser")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("LoComercio.Models.ApplicationUser")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("LoComercio.Models.ApplicationUser")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
