using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Datos.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    Identificacion = table.Column<string>(type: "varchar(12)", nullable: false),
                    Tipo = table.Column<string>(type: "varchar(20)", nullable: true),
                    Nombre = table.Column<string>(type: "varchar(30)", nullable: true),
                    Direccion = table.Column<string>(type: "varchar(30)", nullable: true),
                    Telefono = table.Column<string>(type: "varchar(12)", nullable: true),
                    Pais = table.Column<string>(type: "varchar(20)", nullable: true),
                    Departamento = table.Column<string>(type: "varchar(20)", nullable: true),
                    Ciudad = table.Column<string>(type: "varchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.Identificacion);
                });

            migrationBuilder.CreateTable(
                name: "Pagos",
                columns: table => new
                {
                    Codigo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<string>(type: "varchar(12)", nullable: true),
                    Fecha = table.Column<DateTime>(type: "Date", nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(16)", nullable: false),
                    Iva = table.Column<decimal>(type: "decimal(10)", nullable: false),
                    PersonaIdentificacion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagos", x => x.Codigo);
                    table.ForeignKey(
                        name: "FK_Pagos_Personas_PersonaIdentificacion",
                        column: x => x.PersonaIdentificacion,
                        principalTable: "Personas",
                        principalColumn: "Identificacion",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_PersonaIdentificacion",
                table: "Pagos",
                column: "PersonaIdentificacion");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pagos");

            migrationBuilder.DropTable(
                name: "Personas");
        }
    }
}
