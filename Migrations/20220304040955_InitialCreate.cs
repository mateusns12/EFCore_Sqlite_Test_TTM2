using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace p1.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Grafico",
                columns: table => new
                {
                    GraficoID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Material = table.Column<string>(type: "TEXT", nullable: false),
                    Registro = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grafico", x => x.GraficoID);
                });

            migrationBuilder.CreateTable(
                name: "Dados",
                columns: table => new
                {
                    IndexID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Carga = table.Column<float>(type: "REAL", nullable: false),
                    Deslocamento = table.Column<float>(type: "REAL", nullable: false),
                    GraficoForeingKey = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dados", x => x.IndexID);
                    table.ForeignKey(
                        name: "FK_Dados_Grafico_GraficoForeingKey",
                        column: x => x.GraficoForeingKey,
                        principalTable: "Grafico",
                        principalColumn: "GraficoID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dados_GraficoForeingKey",
                table: "Dados",
                column: "GraficoForeingKey");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dados");

            migrationBuilder.DropTable(
                name: "Grafico");
        }
    }
}
