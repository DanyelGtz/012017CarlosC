using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LoComercio.Data.Migrations
{
    public partial class Modelo2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "IdTipoServicio",
                table: "OrdenesServicio",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrdenesServicio_IdMarca",
                table: "OrdenesServicio",
                column: "IdMarca");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenesServicio_IdTipoServicio",
                table: "OrdenesServicio",
                column: "IdTipoServicio");

            migrationBuilder.AddForeignKey(
                name: "FK_OrdenesServicio_Marcas_IdMarca",
                table: "OrdenesServicio",
                column: "IdMarca",
                principalTable: "Marcas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrdenesServicio_TiposServicio_IdTipoServicio",
                table: "OrdenesServicio",
                column: "IdTipoServicio",
                principalTable: "TiposServicio",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrdenesServicio_Marcas_IdMarca",
                table: "OrdenesServicio");

            migrationBuilder.DropForeignKey(
                name: "FK_OrdenesServicio_TiposServicio_IdTipoServicio",
                table: "OrdenesServicio");

            migrationBuilder.DropIndex(
                name: "IX_OrdenesServicio_IdMarca",
                table: "OrdenesServicio");

            migrationBuilder.DropIndex(
                name: "IX_OrdenesServicio_IdTipoServicio",
                table: "OrdenesServicio");

            migrationBuilder.DropColumn(
                name: "IdTipoServicio",
                table: "OrdenesServicio");
        }
    }
}
