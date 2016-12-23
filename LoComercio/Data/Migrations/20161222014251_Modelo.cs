using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LoComercio.Data.Migrations
{
    public partial class Modelo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accesorios",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    CantMax = table.Column<int>(nullable: false),
                    CantMin = table.Column<int>(nullable: false),
                    Existencia = table.Column<int>(nullable: false),
                    Nombre = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accesorios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Email = table.Column<string>(nullable: false),
                    Nombre = table.Column<string>(nullable: false),
                    RFC = table.Column<string>(nullable: false),
                    TelefonoActual = table.Column<string>(nullable: false),
                    TelefonoContacto = table.Column<string>(nullable: false),
                    WhatssApp = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EstadosAccesorios",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Nombre = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadosAccesorios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EstadosDispositivos",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Nombre = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadosDispositivos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EstadosNotificaciones",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Nombre = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadosNotificaciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EstadosRefacciones",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Nombre = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadosRefacciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EstadosServicios",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Nombre = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadosServicios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FormasPagos",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Nombre = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormasPagos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LugaresAlmacenamiento",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Nombre = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LugaresAlmacenamiento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Marcas",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Nombre = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marcas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Modelos",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    IdMarca = table.Column<long>(nullable: true),
                    ModeloComercial = table.Column<string>(nullable: false),
                    Nombre = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modelos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Modelos_Modelos_IdMarca",
                        column: x => x.IdMarca,
                        principalTable: "Modelos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Refacciones",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    CantMax = table.Column<int>(nullable: false),
                    CantMin = table.Column<int>(nullable: false),
                    Existencia = table.Column<int>(nullable: false),
                    Nombre = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Refacciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposCambio",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Nombre = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposCambio", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposNotificaciones",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Nombre = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposNotificaciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposServicio",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Nombre = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposServicio", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposTecnico",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Nombre = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposTecnico", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SolicitudAccesorios",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Cantidad = table.Column<int>(nullable: false),
                    Fecha = table.Column<DateTime>(nullable: false),
                    IdAccesorio = table.Column<long>(nullable: true),
                    IdEdoAccesorio = table.Column<long>(nullable: true),
                    IdUsuario = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolicitudAccesorios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SolicitudAccesorios_Accesorios_IdAccesorio",
                        column: x => x.IdAccesorio,
                        principalTable: "Accesorios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SolicitudAccesorios_EstadosAccesorios_IdEdoAccesorio",
                        column: x => x.IdEdoAccesorio,
                        principalTable: "EstadosAccesorios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pagos",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Anticipo = table.Column<float>(nullable: false),
                    Fecha = table.Column<DateTime>(nullable: false),
                    IdFormaPago = table.Column<long>(nullable: true),
                    Monto = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pagos_FormasPagos_IdFormaPago",
                        column: x => x.IdFormaPago,
                        principalTable: "FormasPagos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SolicitudRefacciones",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Cantidad = table.Column<int>(nullable: false),
                    Fecha = table.Column<DateTime>(nullable: false),
                    IdEdoRefaccion = table.Column<long>(nullable: true),
                    IdRefaccion = table.Column<long>(nullable: true),
                    IdUsuario = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolicitudRefacciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SolicitudRefacciones_EstadosRefacciones_IdEdoRefaccion",
                        column: x => x.IdEdoRefaccion,
                        principalTable: "EstadosRefacciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SolicitudRefacciones_Refacciones_IdRefaccion",
                        column: x => x.IdRefaccion,
                        principalTable: "Refacciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BitacoraEstados",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Descripcion = table.Column<string>(nullable: false),
                    Fecha = table.Column<DateTime>(nullable: false),
                    IdTipoCambio = table.Column<long>(nullable: true),
                    IdUsuario = table.Column<long>(nullable: true),
                    Observacion = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BitacoraEstados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BitacoraEstados_TiposCambio_IdTipoCambio",
                        column: x => x.IdTipoCambio,
                        principalTable: "TiposCambio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BitacoraNotificaciones",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Descripcion = table.Column<string>(nullable: false),
                    Fecha = table.Column<DateTime>(nullable: false),
                    IdTipoCambio = table.Column<long>(nullable: true),
                    IdUsuario = table.Column<long>(nullable: true),
                    Observacion = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BitacoraNotificaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BitacoraNotificaciones_TiposCambio_IdTipoCambio",
                        column: x => x.IdTipoCambio,
                        principalTable: "TiposCambio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Servicios",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    IdTipoServicio = table.Column<long>(nullable: true),
                    Nombre = table.Column<string>(nullable: false),
                    Precio = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Servicios_TiposServicio_IdTipoServicio",
                        column: x => x.IdTipoServicio,
                        principalTable: "TiposServicio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tecnicos",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    IdTipoTecnico = table.Column<long>(nullable: true),
                    Nombre = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tecnicos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tecnicos_TiposTecnico_IdTipoTecnico",
                        column: x => x.IdTipoTecnico,
                        principalTable: "TiposTecnico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrdenesServicioServicio",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    IdEdoServicio = table.Column<long>(nullable: true),
                    IdServicio = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdenesServicioServicio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrdenesServicioServicio_EstadosServicios_IdEdoServicio",
                        column: x => x.IdEdoServicio,
                        principalTable: "EstadosServicios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrdenesServicioServicio_Servicios_IdServicio",
                        column: x => x.IdServicio,
                        principalTable: "Servicios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrdenesServicio",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    AceptaRiesgo = table.Column<bool>(nullable: false),
                    ColorDispositivo = table.Column<string>(nullable: true),
                    ColorPieza = table.Column<string>(nullable: true),
                    CompanyaOrigen = table.Column<string>(nullable: false),
                    DejaAccesorios = table.Column<bool>(nullable: false),
                    DesactivoICloud = table.Column<bool>(nullable: false),
                    DescripcionAccesorios = table.Column<string>(nullable: true),
                    DescripcionFalla = table.Column<string>(nullable: false),
                    DescripcionRevisionAdicional = table.Column<string>(nullable: true),
                    EquipoApagado = table.Column<bool>(nullable: false),
                    EquipoMojado = table.Column<bool>(nullable: false),
                    FechaLlegada = table.Column<DateTime>(nullable: false),
                    FechaPosibleSalida = table.Column<DateTime>(nullable: false),
                    FechaSalida = table.Column<DateTime>(nullable: false),
                    IMEI = table.Column<string>(nullable: false),
                    IdCliente = table.Column<long>(nullable: true),
                    IdEdoDispositivo = table.Column<long>(nullable: true),
                    IdEdoNotificacion = table.Column<long>(nullable: true),
                    IdLugarAlmacenamiento = table.Column<long>(nullable: true),
                    IdMarca = table.Column<long>(nullable: true),
                    IdModeloTecnico = table.Column<long>(nullable: true),
                    IdPago = table.Column<long>(nullable: true),
                    IdPersonalEntrega = table.Column<long>(nullable: true),
                    IdSolAccesorio = table.Column<long>(nullable: true),
                    IdSolRefaccion = table.Column<long>(nullable: true),
                    IdTecnico = table.Column<long>(nullable: true),
                    ImplicaRiesgo = table.Column<bool>(nullable: false),
                    NotasReparaciones = table.Column<string>(nullable: true),
                    Observaciones = table.Column<string>(nullable: true),
                    PasswordDesbloqueo = table.Column<string>(nullable: true),
                    PatronDesbloqueo = table.Column<string>(nullable: true),
                    ReparadoAnteriormente = table.Column<bool>(nullable: false),
                    RevisionAdicional = table.Column<bool>(nullable: false),
                    UsuarioRecibe = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdenesServicio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrdenesServicio_Clientes_IdCliente",
                        column: x => x.IdCliente,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrdenesServicio_EstadosDispositivos_IdEdoDispositivo",
                        column: x => x.IdEdoDispositivo,
                        principalTable: "EstadosDispositivos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrdenesServicio_EstadosNotificaciones_IdEdoNotificacion",
                        column: x => x.IdEdoNotificacion,
                        principalTable: "EstadosNotificaciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrdenesServicio_LugaresAlmacenamiento_IdLugarAlmacenamiento",
                        column: x => x.IdLugarAlmacenamiento,
                        principalTable: "LugaresAlmacenamiento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrdenesServicio_Modelos_IdModeloTecnico",
                        column: x => x.IdModeloTecnico,
                        principalTable: "Modelos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrdenesServicio_Pagos_IdPago",
                        column: x => x.IdPago,
                        principalTable: "Pagos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrdenesServicio_SolicitudAccesorios_IdSolAccesorio",
                        column: x => x.IdSolAccesorio,
                        principalTable: "SolicitudAccesorios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrdenesServicio_SolicitudRefacciones_IdSolRefaccion",
                        column: x => x.IdSolRefaccion,
                        principalTable: "SolicitudRefacciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrdenesServicio_Tecnicos_IdTecnico",
                        column: x => x.IdTecnico,
                        principalTable: "Tecnicos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Notificaciones",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Fecha = table.Column<DateTime>(nullable: false),
                    IdOrdenServicio = table.Column<long>(nullable: true),
                    IdTipoNotificacion = table.Column<long>(nullable: true),
                    NotificacionActiva = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notificaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notificaciones_OrdenesServicio_IdOrdenServicio",
                        column: x => x.IdOrdenServicio,
                        principalTable: "OrdenesServicio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Notificaciones_TiposNotificaciones_IdTipoNotificacion",
                        column: x => x.IdTipoNotificacion,
                        principalTable: "TiposNotificaciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BitacoraEstados_IdTipoCambio",
                table: "BitacoraEstados",
                column: "IdTipoCambio");

            migrationBuilder.CreateIndex(
                name: "IX_BitacoraNotificaciones_IdTipoCambio",
                table: "BitacoraNotificaciones",
                column: "IdTipoCambio");

            migrationBuilder.CreateIndex(
                name: "IX_Modelos_IdMarca",
                table: "Modelos",
                column: "IdMarca");

            migrationBuilder.CreateIndex(
                name: "IX_Notificaciones_IdOrdenServicio",
                table: "Notificaciones",
                column: "IdOrdenServicio");

            migrationBuilder.CreateIndex(
                name: "IX_Notificaciones_IdTipoNotificacion",
                table: "Notificaciones",
                column: "IdTipoNotificacion");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenesServicio_IdCliente",
                table: "OrdenesServicio",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenesServicio_IdEdoDispositivo",
                table: "OrdenesServicio",
                column: "IdEdoDispositivo");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenesServicio_IdEdoNotificacion",
                table: "OrdenesServicio",
                column: "IdEdoNotificacion");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenesServicio_IdLugarAlmacenamiento",
                table: "OrdenesServicio",
                column: "IdLugarAlmacenamiento");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenesServicio_IdModeloTecnico",
                table: "OrdenesServicio",
                column: "IdModeloTecnico");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenesServicio_IdPago",
                table: "OrdenesServicio",
                column: "IdPago");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenesServicio_IdSolAccesorio",
                table: "OrdenesServicio",
                column: "IdSolAccesorio");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenesServicio_IdSolRefaccion",
                table: "OrdenesServicio",
                column: "IdSolRefaccion");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenesServicio_IdTecnico",
                table: "OrdenesServicio",
                column: "IdTecnico");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenesServicioServicio_IdEdoServicio",
                table: "OrdenesServicioServicio",
                column: "IdEdoServicio");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenesServicioServicio_IdServicio",
                table: "OrdenesServicioServicio",
                column: "IdServicio");

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_IdFormaPago",
                table: "Pagos",
                column: "IdFormaPago");

            migrationBuilder.CreateIndex(
                name: "IX_Servicios_IdTipoServicio",
                table: "Servicios",
                column: "IdTipoServicio");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitudAccesorios_IdAccesorio",
                table: "SolicitudAccesorios",
                column: "IdAccesorio");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitudAccesorios_IdEdoAccesorio",
                table: "SolicitudAccesorios",
                column: "IdEdoAccesorio");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitudRefacciones_IdEdoRefaccion",
                table: "SolicitudRefacciones",
                column: "IdEdoRefaccion");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitudRefacciones_IdRefaccion",
                table: "SolicitudRefacciones",
                column: "IdRefaccion");

            migrationBuilder.CreateIndex(
                name: "IX_Tecnicos_IdTipoTecnico",
                table: "Tecnicos",
                column: "IdTipoTecnico");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BitacoraEstados");

            migrationBuilder.DropTable(
                name: "BitacoraNotificaciones");

            migrationBuilder.DropTable(
                name: "Marcas");

            migrationBuilder.DropTable(
                name: "Notificaciones");

            migrationBuilder.DropTable(
                name: "OrdenesServicioServicio");

            migrationBuilder.DropTable(
                name: "TiposCambio");

            migrationBuilder.DropTable(
                name: "OrdenesServicio");

            migrationBuilder.DropTable(
                name: "TiposNotificaciones");

            migrationBuilder.DropTable(
                name: "EstadosServicios");

            migrationBuilder.DropTable(
                name: "Servicios");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "EstadosDispositivos");

            migrationBuilder.DropTable(
                name: "EstadosNotificaciones");

            migrationBuilder.DropTable(
                name: "LugaresAlmacenamiento");

            migrationBuilder.DropTable(
                name: "Modelos");

            migrationBuilder.DropTable(
                name: "Pagos");

            migrationBuilder.DropTable(
                name: "SolicitudAccesorios");

            migrationBuilder.DropTable(
                name: "SolicitudRefacciones");

            migrationBuilder.DropTable(
                name: "Tecnicos");

            migrationBuilder.DropTable(
                name: "TiposServicio");

            migrationBuilder.DropTable(
                name: "FormasPagos");

            migrationBuilder.DropTable(
                name: "Accesorios");

            migrationBuilder.DropTable(
                name: "EstadosAccesorios");

            migrationBuilder.DropTable(
                name: "EstadosRefacciones");

            migrationBuilder.DropTable(
                name: "Refacciones");

            migrationBuilder.DropTable(
                name: "TiposTecnico");
        }
    }
}
