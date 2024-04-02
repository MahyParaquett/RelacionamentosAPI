using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RelacionamentosAPI.Migrations
{
    /// <inheritdoc />
    public partial class CasaMoradorRelacionamento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CasaModelMoradorModel",
                columns: table => new
                {
                    CasaId = table.Column<int>(type: "int", nullable: false),
                    MoradorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CasaModelMoradorModel", x => new { x.CasaId, x.MoradorId });
                    table.ForeignKey(
                        name: "FK_CasaModelMoradorModel_Casas_CasaId",
                        column: x => x.CasaId,
                        principalTable: "Casas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CasaModelMoradorModel_Moradores_MoradorId",
                        column: x => x.MoradorId,
                        principalTable: "Moradores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CasaModelMoradorModel_MoradorId",
                table: "CasaModelMoradorModel",
                column: "MoradorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CasaModelMoradorModel");
        }
    }
}
