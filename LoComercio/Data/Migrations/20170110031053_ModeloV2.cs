using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Data.Migrations
{
    public partial class ModeloV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmpresaTelefonica",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Nombre = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpresaTelefonica", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmpresaTelefonica");
        }
    }
}
