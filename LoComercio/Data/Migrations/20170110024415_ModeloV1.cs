using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Data.Migrations
{
    public partial class ModeloV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accesorio",
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
                    table.PrimaryKey("PK_Accesorio", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Email = table.Column<string>(nullable: false),
                    Nombre = table.Column<string>(nullable: false),
                    RFC = table.Column<string>(nullable: true),
                    TelefonoActual = table.Column<string>(nullable: false),
                    TelefonoContacto = table.Column<string>(nullable: false),
                    WhatssApp = table.Column<bool>(nullable: false),
                    WhatssApp2 = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EstadoAccesorio",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Nombre = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoAccesorio", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EstadoDispositivo",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Nombre = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoDispositivo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EstadoNotificacion",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Nombre = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoNotificacion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EstadoRefaccion",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Nombre = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoRefaccion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EstadoServicio",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Nombre = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoServicio", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FormaPago",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Nombre = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormaPago", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LugarAlmacenamiento",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Nombre = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LugarAlmacenamiento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Marca",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Nombre = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marca", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Refaccion",
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
                    table.PrimaryKey("PK_Refaccion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoCambio",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Nombre = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoCambio", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoNotificacion",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Nombre = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoNotificacion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoServicio",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Nombre = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoServicio", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoTecnico",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Nombre = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoTecnico", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SolicitudAccesorio",
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
                    table.PrimaryKey("PK_SolicitudAccesorio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SolicitudAccesorio_Accesorio_IdAccesorio",
                        column: x => x.IdAccesorio,
                        principalTable: "Accesorio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SolicitudAccesorio_EstadoAccesorio_IdEdoAccesorio",
                        column: x => x.IdEdoAccesorio,
                        principalTable: "EstadoAccesorio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pago",
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
                    table.PrimaryKey("PK_Pago", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pago_FormaPago_IdFormaPago",
                        column: x => x.IdFormaPago,
                        principalTable: "FormaPago",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Modelo",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    IdMarca = table.Column<long>(nullable: false),
                    ModeloTecnico = table.Column<string>(nullable: false),
                    Nombre = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modelo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Modelo_Marca_IdMarca",
                        column: x => x.IdMarca,
                        principalTable: "Marca",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SolicitudRefaccion",
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
                    table.PrimaryKey("PK_SolicitudRefaccion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SolicitudRefaccion_EstadoRefaccion_IdEdoRefaccion",
                        column: x => x.IdEdoRefaccion,
                        principalTable: "EstadoRefaccion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SolicitudRefaccion_Refaccion_IdRefaccion",
                        column: x => x.IdRefaccion,
                        principalTable: "Refaccion",
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
                        name: "FK_BitacoraEstados_TipoCambio_IdTipoCambio",
                        column: x => x.IdTipoCambio,
                        principalTable: "TipoCambio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BitacoraNotifiaciones",
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
                    table.PrimaryKey("PK_BitacoraNotifiaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BitacoraNotifiaciones_TipoCambio_IdTipoCambio",
                        column: x => x.IdTipoCambio,
                        principalTable: "TipoCambio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tecnico",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    IdTipoTecnico = table.Column<long>(nullable: true),
                    Nombre = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tecnico", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tecnico_TipoTecnico_IdTipoTecnico",
                        column: x => x.IdTipoTecnico,
                        principalTable: "TipoTecnico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Servicio",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    IdModelo = table.Column<long>(nullable: true),
                    IdTipoServicio = table.Column<long>(nullable: true),
                    Nombre = table.Column<string>(nullable: false),
                    PrecioMaximo = table.Column<float>(nullable: false),
                    PrecioMinimo = table.Column<float>(nullable: false),
                    PrecioSugerido = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Servicio_Modelo_IdModelo",
                        column: x => x.IdModelo,
                        principalTable: "Modelo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Servicio_TipoServicio_IdTipoServicio",
                        column: x => x.IdTipoServicio,
                        principalTable: "TipoServicio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrdenServicio",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    AceptaRiesgo = table.Column<bool>(nullable: false),
                    ColorDispositivo = table.Column<string>(nullable: true),
                    ColorPieza = table.Column<string>(nullable: true),
                    CompanyaOrigen = table.Column<string>(nullable: true),
                    DejaAccesorios = table.Column<bool>(nullable: false),
                    DesactivoICloud = table.Column<bool>(nullable: false),
                    DescripcionAccesorios = table.Column<string>(nullable: true),
                    DescripcionFalla = table.Column<string>(nullable: true),
                    DescripcionRevisionAdicional = table.Column<string>(nullable: true),
                    EquipoApagado = table.Column<bool>(nullable: false),
                    EquipoMojado = table.Column<bool>(nullable: false),
                    FechaLlegada = table.Column<DateTime>(nullable: false),
                    FechaPosibleSalida = table.Column<DateTime>(nullable: false),
                    FechaSalida = table.Column<DateTime>(nullable: false),
                    IMEI = table.Column<string>(nullable: true),
                    IdCliente = table.Column<long>(nullable: true),
                    IdEdoDispositivo = table.Column<long>(nullable: true),
                    IdEdoNotificacion = table.Column<long>(nullable: true),
                    IdLugarAlmacenamiento = table.Column<long>(nullable: true),
                    IdMarca = table.Column<long>(nullable: true),
                    IdModelo = table.Column<long>(nullable: true),
                    IdPago = table.Column<long>(nullable: true),
                    IdPersonalEntrega = table.Column<long>(nullable: true),
                    IdSolAccesorio = table.Column<long>(nullable: true),
                    IdSolRefaccion = table.Column<long>(nullable: true),
                    IdTecnico = table.Column<long>(nullable: true),
                    IdTipoServicio = table.Column<long>(nullable: true),
                    ImplicaRiesgo = table.Column<bool>(nullable: false),
                    NotasReparaciones = table.Column<string>(nullable: true),
                    Observaciones = table.Column<string>(nullable: true),
                    PasswordDesbloqueo = table.Column<string>(nullable: true),
                    PatronDesbloqueo = table.Column<string>(nullable: true),
                    ReparadoAnteriormente = table.Column<bool>(nullable: false),
                    RevisionAdicional = table.Column<bool>(nullable: false),
                    UsuarioRecibe = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdenServicio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrdenServicio_Cliente_IdCliente",
                        column: x => x.IdCliente,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrdenServicio_EstadoDispositivo_IdEdoDispositivo",
                        column: x => x.IdEdoDispositivo,
                        principalTable: "EstadoDispositivo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrdenServicio_EstadoNotificacion_IdEdoNotificacion",
                        column: x => x.IdEdoNotificacion,
                        principalTable: "EstadoNotificacion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrdenServicio_LugarAlmacenamiento_IdLugarAlmacenamiento",
                        column: x => x.IdLugarAlmacenamiento,
                        principalTable: "LugarAlmacenamiento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrdenServicio_Marca_IdMarca",
                        column: x => x.IdMarca,
                        principalTable: "Marca",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrdenServicio_Modelo_IdModelo",
                        column: x => x.IdModelo,
                        principalTable: "Modelo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrdenServicio_Pago_IdPago",
                        column: x => x.IdPago,
                        principalTable: "Pago",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrdenServicio_SolicitudAccesorio_IdSolAccesorio",
                        column: x => x.IdSolAccesorio,
                        principalTable: "SolicitudAccesorio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrdenServicio_SolicitudRefaccion_IdSolRefaccion",
                        column: x => x.IdSolRefaccion,
                        principalTable: "SolicitudRefaccion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrdenServicio_Tecnico_IdTecnico",
                        column: x => x.IdTecnico,
                        principalTable: "Tecnico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrdenServicio_TipoServicio_IdTipoServicio",
                        column: x => x.IdTipoServicio,
                        principalTable: "TipoServicio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Notificacion",
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
                    table.PrimaryKey("PK_Notificacion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notificacion_OrdenServicio_IdOrdenServicio",
                        column: x => x.IdOrdenServicio,
                        principalTable: "OrdenServicio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Notificacion_TipoNotificacion_IdTipoNotificacion",
                        column: x => x.IdTipoNotificacion,
                        principalTable: "TipoNotificacion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrdenServicioServicio",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    IdEdoServicio = table.Column<long>(nullable: false),
                    IdOrdenServicio = table.Column<long>(nullable: false),
                    IdServicio = table.Column<long>(nullable: false),
                    PrecioServicio = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdenServicioServicio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrdenServicioServicio_EstadoServicio_IdEdoServicio",
                        column: x => x.IdEdoServicio,
                        principalTable: "EstadoServicio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrdenServicioServicio_OrdenServicio_IdOrdenServicio",
                        column: x => x.IdOrdenServicio,
                        principalTable: "OrdenServicio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrdenServicioServicio_Servicio_IdServicio",
                        column: x => x.IdServicio,
                        principalTable: "Servicio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BitacoraEstados_IdTipoCambio",
                table: "BitacoraEstados",
                column: "IdTipoCambio");

            migrationBuilder.CreateIndex(
                name: "IX_BitacoraNotifiaciones_IdTipoCambio",
                table: "BitacoraNotifiaciones",
                column: "IdTipoCambio");

            migrationBuilder.CreateIndex(
                name: "IX_Modelo_IdMarca",
                table: "Modelo",
                column: "IdMarca");

            migrationBuilder.CreateIndex(
                name: "IX_Notificacion_IdOrdenServicio",
                table: "Notificacion",
                column: "IdOrdenServicio");

            migrationBuilder.CreateIndex(
                name: "IX_Notificacion_IdTipoNotificacion",
                table: "Notificacion",
                column: "IdTipoNotificacion");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenServicio_IdCliente",
                table: "OrdenServicio",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenServicio_IdEdoDispositivo",
                table: "OrdenServicio",
                column: "IdEdoDispositivo");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenServicio_IdEdoNotificacion",
                table: "OrdenServicio",
                column: "IdEdoNotificacion");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenServicio_IdLugarAlmacenamiento",
                table: "OrdenServicio",
                column: "IdLugarAlmacenamiento");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenServicio_IdMarca",
                table: "OrdenServicio",
                column: "IdMarca");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenServicio_IdModelo",
                table: "OrdenServicio",
                column: "IdModelo");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenServicio_IdPago",
                table: "OrdenServicio",
                column: "IdPago");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenServicio_IdSolAccesorio",
                table: "OrdenServicio",
                column: "IdSolAccesorio");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenServicio_IdSolRefaccion",
                table: "OrdenServicio",
                column: "IdSolRefaccion");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenServicio_IdTecnico",
                table: "OrdenServicio",
                column: "IdTecnico");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenServicio_IdTipoServicio",
                table: "OrdenServicio",
                column: "IdTipoServicio");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenServicioServicio_IdEdoServicio",
                table: "OrdenServicioServicio",
                column: "IdEdoServicio");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenServicioServicio_IdOrdenServicio",
                table: "OrdenServicioServicio",
                column: "IdOrdenServicio");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenServicioServicio_IdServicio",
                table: "OrdenServicioServicio",
                column: "IdServicio");

            migrationBuilder.CreateIndex(
                name: "IX_Pago_IdFormaPago",
                table: "Pago",
                column: "IdFormaPago");

            migrationBuilder.CreateIndex(
                name: "IX_Servicio_IdModelo",
                table: "Servicio",
                column: "IdModelo");

            migrationBuilder.CreateIndex(
                name: "IX_Servicio_IdTipoServicio",
                table: "Servicio",
                column: "IdTipoServicio");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitudAccesorio_IdAccesorio",
                table: "SolicitudAccesorio",
                column: "IdAccesorio");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitudAccesorio_IdEdoAccesorio",
                table: "SolicitudAccesorio",
                column: "IdEdoAccesorio");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitudRefaccion_IdEdoRefaccion",
                table: "SolicitudRefaccion",
                column: "IdEdoRefaccion");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitudRefaccion_IdRefaccion",
                table: "SolicitudRefaccion",
                column: "IdRefaccion");

            migrationBuilder.CreateIndex(
                name: "IX_Tecnico_IdTipoTecnico",
                table: "Tecnico",
                column: "IdTipoTecnico");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BitacoraEstados");

            migrationBuilder.DropTable(
                name: "BitacoraNotifiaciones");

            migrationBuilder.DropTable(
                name: "Notificacion");

            migrationBuilder.DropTable(
                name: "OrdenServicioServicio");

            migrationBuilder.DropTable(
                name: "TipoCambio");

            migrationBuilder.DropTable(
                name: "TipoNotificacion");

            migrationBuilder.DropTable(
                name: "EstadoServicio");

            migrationBuilder.DropTable(
                name: "OrdenServicio");

            migrationBuilder.DropTable(
                name: "Servicio");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "EstadoDispositivo");

            migrationBuilder.DropTable(
                name: "EstadoNotificacion");

            migrationBuilder.DropTable(
                name: "LugarAlmacenamiento");

            migrationBuilder.DropTable(
                name: "Pago");

            migrationBuilder.DropTable(
                name: "SolicitudAccesorio");

            migrationBuilder.DropTable(
                name: "SolicitudRefaccion");

            migrationBuilder.DropTable(
                name: "Tecnico");

            migrationBuilder.DropTable(
                name: "Modelo");

            migrationBuilder.DropTable(
                name: "TipoServicio");

            migrationBuilder.DropTable(
                name: "FormaPago");

            migrationBuilder.DropTable(
                name: "Accesorio");

            migrationBuilder.DropTable(
                name: "EstadoAccesorio");

            migrationBuilder.DropTable(
                name: "EstadoRefaccion");

            migrationBuilder.DropTable(
                name: "Refaccion");

            migrationBuilder.DropTable(
                name: "TipoTecnico");

            migrationBuilder.DropTable(
                name: "Marca");
        }
    }
}
