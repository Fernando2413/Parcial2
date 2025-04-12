using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Parcial2.Migrations
{
    /// <inheritdoc />
    public partial class PrimeraMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "autor",
                columns: table => new
                {
                    id_Autor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    nacionalidad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_autor", x => x.id_Autor);
                });

            migrationBuilder.CreateTable(
                name: "libro",
                columns: table => new
                {
                    id_Libro = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    titulo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    editorial = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    area = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    cover_Url = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    digital_Url = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    disponible_Fisico = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_libro", x => x.id_Libro);
                });

            migrationBuilder.CreateTable(
                name: "libro_autor",
                columns: table => new
                {
                    id_Libro_Autor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_Libro = table.Column<int>(type: "int", nullable: false),
                    id_Autor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_libro_autor", x => x.id_Libro_Autor);
                });

            migrationBuilder.CreateTable(
                name: "prestamo",
                columns: table => new
                {
                    id_Usuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_Prestamo = table.Column<int>(type: "int", nullable: false),
                    fecha_Prestamo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fecha_Devolucion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Devuelto = table.Column<bool>(type: "bit", nullable: false),
                    id_Libro = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prestamo", x => x.id_Usuario);
                });

            migrationBuilder.CreateTable(
                name: "usuario",
                columns: table => new
                {
                    id_Usuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    programa = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    fecha_Nacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    correo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuario", x => x.id_Usuario);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "autor");

            migrationBuilder.DropTable(
                name: "libro");

            migrationBuilder.DropTable(
                name: "libro_autor");

            migrationBuilder.DropTable(
                name: "prestamo");

            migrationBuilder.DropTable(
                name: "usuario");
        }
    }
}
