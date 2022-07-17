using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gestor_Proyectos.API.Migrations
{
    public partial class AddTableRequerimiento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Requerimientos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha_Reg = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Nombre_Iniciativa = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Detalle_Req = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aplicativo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sustentac_Req = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Objetivo1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Objetivo2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Objetivo3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Indicador1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Indicador2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Indicador3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Eviden_Mejora = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Periodo_Ent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fecha_Entrega = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ppto_Aprox = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Ppto_Area = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requerimientos", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Requerimientos_Nombre_Iniciativa",
                table: "Requerimientos",
                column: "Nombre_Iniciativa",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Requerimientos");
        }
    }
}
