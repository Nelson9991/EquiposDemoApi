using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EquiposDemoApi.Migrations
{
    /// <inheritdoc />
    public partial class AgregarDatosCategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CategoriasEquipos",
                columns: new[] { "Id", "NombreCategoria" },
                values: new object[,]
                {
                    { 1, "Electrodomesticos" },
                    { 2, "Construccion" },
                    { 3, "Utiles Medicos" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CategoriasEquipos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CategoriasEquipos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CategoriasEquipos",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
