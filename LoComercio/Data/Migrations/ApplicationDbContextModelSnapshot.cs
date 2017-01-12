using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using LoDesbloqueo.Data;

namespace WebApplication1.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1");

            modelBuilder.Entity("LoDesbloqueo.Data.Accesorio", b =>
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

                    b.ToTable("Accesorio");
                });

            modelBuilder.Entity("LoDesbloqueo.Data.BitacoraEstados", b =>
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

            modelBuilder.Entity("LoDesbloqueo.Data.BitacoraNotifiaciones", b =>
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

                    b.ToTable("BitacoraNotifiaciones");
                });

            modelBuilder.Entity("LoDesbloqueo.Data.Cliente", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.Property<string>("RFC");

                    b.Property<string>("TelefonoActual")
                        .IsRequired();

                    b.Property<string>("TelefonoContacto")
                        .IsRequired();

                    b.Property<bool>("WhatssApp");

                    b.Property<bool>("WhatssApp2");

                    b.HasKey("Id");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("LoDesbloqueo.Data.EmpresaTelefonica", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("EmpresaTelefonica");
                });

            modelBuilder.Entity("LoDesbloqueo.Data.EstadoAccesorio", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("EstadoAccesorio");
                });

            modelBuilder.Entity("LoDesbloqueo.Data.EstadoDispositivo", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("EstadoDispositivo");
                });

            modelBuilder.Entity("LoDesbloqueo.Data.EstadoNotificacion", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("EstadoNotificacion");
                });

            modelBuilder.Entity("LoDesbloqueo.Data.EstadoRefaccion", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("EstadoRefaccion");
                });

            modelBuilder.Entity("LoDesbloqueo.Data.EstadoServicio", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("EstadoServicio");
                });

            modelBuilder.Entity("LoDesbloqueo.Data.FormaPago", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("FormaPago");
                });

            modelBuilder.Entity("LoDesbloqueo.Data.LugarAlmacenamiento", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("LugarAlmacenamiento");
                });

            modelBuilder.Entity("LoDesbloqueo.Data.Marca", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Marca");
                });

            modelBuilder.Entity("LoDesbloqueo.Data.Modelo", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("IdMarca")
                        .IsRequired();

                    b.Property<string>("ModeloTecnico")
                        .IsRequired();

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("IdMarca");

                    b.ToTable("Modelo");
                });

            modelBuilder.Entity("LoDesbloqueo.Data.Notificacion", b =>
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

                    b.ToTable("Notificacion");
                });

            modelBuilder.Entity("LoDesbloqueo.Data.OrdenServicio", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("AceptaRiesgo");

                    b.Property<string>("ColorPieza");

                    b.Property<string>("CompanyaOrigen");

                    b.Property<bool>("DejaAccesorios");

                    b.Property<bool>("DesactivoICloud");

                    b.Property<string>("DescripcionAccesorios");

                    b.Property<string>("DescripcionFalla");

                    b.Property<string>("DescripcionRevisionAdicional");

                    b.Property<bool>("EquipoApagado");

                    b.Property<bool>("EquipoMojado");

                    b.Property<DateTime>("FechaLlegada");

                    b.Property<DateTime>("FechaPosibleSalida");

                    b.Property<DateTime>("FechaSalida");

                    b.Property<string>("IMEI");

                    b.Property<long?>("IdCliente");

                    b.Property<long?>("IdEdoDispositivo");

                    b.Property<long?>("IdLugarAlmacenamiento");

                    b.Property<long?>("IdMarca");

                    b.Property<long?>("IdModelo");

                    b.Property<long?>("IdPago");

                    b.Property<long?>("IdPersonalEntrega");

                    b.Property<long?>("IdSolAccesorio");

                    b.Property<long?>("IdSolRefaccion");

                    b.Property<long?>("IdTipoServicio");

                    b.Property<bool>("ImplicaRiesgo");

                    b.Property<string>("NotasReparaciones");

                    b.Property<string>("Observaciones");

                    b.Property<string>("PasswordDesbloqueo");

                    b.Property<string>("PatronDesbloqueo");

                    b.Property<bool>("ReparadoAnteriormente");

                    b.Property<bool>("RevisionAdicional");

                    b.Property<string>("UsuarioRecibe");

                    b.HasKey("Id");

                    b.HasIndex("IdCliente");

                    b.HasIndex("IdEdoDispositivo");

                    b.HasIndex("IdLugarAlmacenamiento");

                    b.HasIndex("IdMarca");

                    b.HasIndex("IdModelo");

                    b.HasIndex("IdPago");

                    b.HasIndex("IdSolAccesorio");

                    b.HasIndex("IdSolRefaccion");

                    b.HasIndex("IdTipoServicio");

                    b.ToTable("OrdenServicio");
                });

            modelBuilder.Entity("LoDesbloqueo.Data.OrdenServicioServicio", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("IdEdoServicio")
                        .IsRequired();

                    b.Property<long?>("IdOrdenServicio")
                        .IsRequired();

                    b.Property<long?>("IdServicio")
                        .IsRequired();

                    b.Property<long?>("IdTecnico");

                    b.Property<string>("Observaciones");

                    b.Property<float>("PrecioServicio");

                    b.HasKey("Id");

                    b.HasIndex("IdEdoServicio");

                    b.HasIndex("IdOrdenServicio");

                    b.HasIndex("IdServicio");

                    b.HasIndex("IdTecnico");

                    b.ToTable("OrdenServicioServicio");
                });

            modelBuilder.Entity("LoDesbloqueo.Data.Pago", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<float>("Anticipo");

                    b.Property<DateTime>("Fecha");

                    b.Property<long?>("IdFormaPago");

                    b.Property<float>("Monto");

                    b.HasKey("Id");

                    b.HasIndex("IdFormaPago");

                    b.ToTable("Pago");
                });

            modelBuilder.Entity("LoDesbloqueo.Data.Refaccion", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CantMax");

                    b.Property<int>("CantMin");

                    b.Property<int>("Existencia");

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Refaccion");
                });

            modelBuilder.Entity("LoDesbloqueo.Data.Servicio", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("IdModelo");

                    b.Property<long?>("IdTipoServicio");

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.Property<float>("PrecioMaximo");

                    b.Property<float>("PrecioMinimo");

                    b.Property<float>("PrecioSugerido");

                    b.HasKey("Id");

                    b.HasIndex("IdModelo");

                    b.HasIndex("IdTipoServicio");

                    b.ToTable("Servicio");
                });

            modelBuilder.Entity("LoDesbloqueo.Data.SolicitudAccesorio", b =>
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

                    b.ToTable("SolicitudAccesorio");
                });

            modelBuilder.Entity("LoDesbloqueo.Data.SolicitudRefaccion", b =>
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

                    b.ToTable("SolicitudRefaccion");
                });

            modelBuilder.Entity("LoDesbloqueo.Data.Tecnico", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("IdTipoTecnico");

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("IdTipoTecnico");

                    b.ToTable("Tecnico");
                });

            modelBuilder.Entity("LoDesbloqueo.Data.TipoCambio", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("TipoCambio");
                });

            modelBuilder.Entity("LoDesbloqueo.Data.TipoNotificacion", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("TipoNotificacion");
                });

            modelBuilder.Entity("LoDesbloqueo.Data.TipoServicio", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("TipoServicio");
                });

            modelBuilder.Entity("LoDesbloqueo.Data.TipoTecnico", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("TipoTecnico");
                });

            modelBuilder.Entity("LoDesbloqueo.Models.ApplicationUser", b =>
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

            modelBuilder.Entity("LoDesbloqueo.Data.BitacoraEstados", b =>
                {
                    b.HasOne("LoDesbloqueo.Data.TipoCambio", "TipoCambio")
                        .WithMany()
                        .HasForeignKey("IdTipoCambio");
                });

            modelBuilder.Entity("LoDesbloqueo.Data.BitacoraNotifiaciones", b =>
                {
                    b.HasOne("LoDesbloqueo.Data.TipoCambio", "TipoCambio")
                        .WithMany()
                        .HasForeignKey("IdTipoCambio");
                });

            modelBuilder.Entity("LoDesbloqueo.Data.Modelo", b =>
                {
                    b.HasOne("LoDesbloqueo.Data.Marca", "Marca")
                        .WithMany()
                        .HasForeignKey("IdMarca")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("LoDesbloqueo.Data.Notificacion", b =>
                {
                    b.HasOne("LoDesbloqueo.Data.OrdenServicio", "OrdenServicio")
                        .WithMany()
                        .HasForeignKey("IdOrdenServicio");

                    b.HasOne("LoDesbloqueo.Data.TipoNotificacion", "TipoNotificacion")
                        .WithMany()
                        .HasForeignKey("IdTipoNotificacion");
                });

            modelBuilder.Entity("LoDesbloqueo.Data.OrdenServicio", b =>
                {
                    b.HasOne("LoDesbloqueo.Data.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("IdCliente");

                    b.HasOne("LoDesbloqueo.Data.EstadoDispositivo", "EstadoDispositivo")
                        .WithMany()
                        .HasForeignKey("IdEdoDispositivo");

                    b.HasOne("LoDesbloqueo.Data.LugarAlmacenamiento", "LugarAlmacenamiento")
                        .WithMany()
                        .HasForeignKey("IdLugarAlmacenamiento");

                    b.HasOne("LoDesbloqueo.Data.Marca", "Marca")
                        .WithMany()
                        .HasForeignKey("IdMarca");

                    b.HasOne("LoDesbloqueo.Data.Modelo", "Modelo")
                        .WithMany()
                        .HasForeignKey("IdModelo");

                    b.HasOne("LoDesbloqueo.Data.Pago", "Pago")
                        .WithMany()
                        .HasForeignKey("IdPago");

                    b.HasOne("LoDesbloqueo.Data.SolicitudAccesorio", "SolicitudAccesorio")
                        .WithMany()
                        .HasForeignKey("IdSolAccesorio");

                    b.HasOne("LoDesbloqueo.Data.SolicitudRefaccion", "SolicitudRefaccion")
                        .WithMany()
                        .HasForeignKey("IdSolRefaccion");

                    b.HasOne("LoDesbloqueo.Data.TipoServicio", "TipoServicio")
                        .WithMany()
                        .HasForeignKey("IdTipoServicio");
                });

            modelBuilder.Entity("LoDesbloqueo.Data.OrdenServicioServicio", b =>
                {
                    b.HasOne("LoDesbloqueo.Data.EstadoServicio", "EstadoServicio")
                        .WithMany()
                        .HasForeignKey("IdEdoServicio")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("LoDesbloqueo.Data.OrdenServicio", "OrdenServicio")
                        .WithMany()
                        .HasForeignKey("IdOrdenServicio")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("LoDesbloqueo.Data.Servicio", "Servicio")
                        .WithMany()
                        .HasForeignKey("IdServicio")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("LoDesbloqueo.Data.Tecnico", "Tecnico")
                        .WithMany()
                        .HasForeignKey("IdTecnico");
                });

            modelBuilder.Entity("LoDesbloqueo.Data.Pago", b =>
                {
                    b.HasOne("LoDesbloqueo.Data.FormaPago", "FormaPago")
                        .WithMany()
                        .HasForeignKey("IdFormaPago");
                });

            modelBuilder.Entity("LoDesbloqueo.Data.Servicio", b =>
                {
                    b.HasOne("LoDesbloqueo.Data.Modelo", "Modelo")
                        .WithMany()
                        .HasForeignKey("IdModelo");

                    b.HasOne("LoDesbloqueo.Data.TipoServicio", "TipoServicio")
                        .WithMany()
                        .HasForeignKey("IdTipoServicio");
                });

            modelBuilder.Entity("LoDesbloqueo.Data.SolicitudAccesorio", b =>
                {
                    b.HasOne("LoDesbloqueo.Data.Accesorio", "Accesorio")
                        .WithMany()
                        .HasForeignKey("IdAccesorio");

                    b.HasOne("LoDesbloqueo.Data.EstadoAccesorio", "EstadoAccesorio")
                        .WithMany()
                        .HasForeignKey("IdEdoAccesorio");
                });

            modelBuilder.Entity("LoDesbloqueo.Data.SolicitudRefaccion", b =>
                {
                    b.HasOne("LoDesbloqueo.Data.EstadoRefaccion", "EstadoRefaccion")
                        .WithMany()
                        .HasForeignKey("IdEdoRefaccion");

                    b.HasOne("LoDesbloqueo.Data.Refaccion", "Refaccion")
                        .WithMany()
                        .HasForeignKey("IdRefaccion");
                });

            modelBuilder.Entity("LoDesbloqueo.Data.Tecnico", b =>
                {
                    b.HasOne("LoDesbloqueo.Data.TipoTecnico", "TipoTecnico")
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
                    b.HasOne("LoDesbloqueo.Models.ApplicationUser")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("LoDesbloqueo.Models.ApplicationUser")
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

                    b.HasOne("LoDesbloqueo.Models.ApplicationUser")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
