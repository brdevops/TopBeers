using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TopBeers.Migrations
{
    public partial class Update1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CervejaModel");

            migrationBuilder.DropTable(
                name: "TipoCervejaModel");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TipoCervejaModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DescricaoTipo = table.Column<string>(nullable: false),
                    Tipo = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoCervejaModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CervejaModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Aprovado = table.Column<bool>(nullable: false),
                    CurrentTipoCervejaId = table.Column<int>(nullable: false),
                    DescricaoCerveja = table.Column<string>(nullable: false),
                    GrauAlcoolico = table.Column<float>(nullable: false),
                    NomeCerveja = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CervejaModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CervejaModel_TipoCervejaModel_CurrentTipoCervejaId",
                        column: x => x.CurrentTipoCervejaId,
                        principalTable: "TipoCervejaModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CervejaModel_CurrentTipoCervejaId",
                table: "CervejaModel",
                column: "CurrentTipoCervejaId");
        }
    }
}
