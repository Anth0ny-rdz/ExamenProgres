using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Examen.Migrations
{
    public partial class AnthonyBdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AnthonyRodriguez_tabla1",
                columns: table => new
                {
                    arCedula = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    arNombre = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    arEstudiante = table.Column<bool>(type: "bit", nullable: false),
                    arEstatura = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnthonyRodriguez_tabla1", x => x.arCedula);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnthonyRodriguez_tabla1");
        }
    }
}
