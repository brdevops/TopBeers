using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TopBeers.Migrations
{
    public partial class Update2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AlterColumn<string>(
            //    name: "Name",
            //    table: "UserToken",
            //    maxLength: 128,
            //    nullable: false,
            //    oldClrType: typeof(string));

            //migrationBuilder.AlterColumn<string>(
            //    name: "LoginProvider",
            //    table: "UserToken",
            //    maxLength: 128,
            //    nullable: false,
            //    oldClrType: typeof(string));

            //migrationBuilder.AlterColumn<string>(
            //    name: "ProviderKey",
            //    table: "UserLogin",
            //    maxLength: 128,
            //    nullable: false,
            //    oldClrType: typeof(string));

            //migrationBuilder.AlterColumn<string>(
            //    name: "LoginProvider",
            //    table: "UserLogin",
            //    maxLength: 128,
            //    nullable: false,
            //    oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Tipo",
                table: "TipoCerveja",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DescricaoTipo",
                table: "TipoCerveja",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NomeCerveja",
                table: "Cerveja",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DescricaoCerveja",
                table: "Cerveja",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Amargor",
                table: "Cerveja",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Aroma",
                table: "Cerveja",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CervejariaId",
                table: "Cerveja",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Coloracao",
                table: "Cerveja",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Foto",
                table: "Cerveja",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Historia",
                table: "Cerveja",
                maxLength: 1000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Origem",
                table: "Cerveja",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Comentario",
                table: "Avaliacao",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Avaliacao",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Cervejaria",
                columns: table => new
                {
                    IdCervejaria = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(maxLength: 50, nullable: true),
                    Fundacao = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cervejaria", x => x.IdCervejaria);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cerveja_CervejariaId",
                table: "Cerveja",
                column: "CervejariaId");

            migrationBuilder.CreateIndex(
                name: "IX_Avaliacao_UsuarioId",
                table: "Avaliacao",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Avaliacao_User_UsuarioId",
                table: "Avaliacao",
                column: "UsuarioId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cerveja_Cervejaria_CervejariaId",
                table: "Cerveja",
                column: "CervejariaId",
                principalTable: "Cervejaria",
                principalColumn: "IdCervejaria",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Avaliacao_User_UsuarioId",
                table: "Avaliacao");

            migrationBuilder.DropForeignKey(
                name: "FK_Cerveja_Cervejaria_CervejariaId",
                table: "Cerveja");

            migrationBuilder.DropTable(
                name: "Cervejaria");

            migrationBuilder.DropIndex(
                name: "IX_Cerveja_CervejariaId",
                table: "Cerveja");

            migrationBuilder.DropIndex(
                name: "IX_Avaliacao_UsuarioId",
                table: "Avaliacao");

            migrationBuilder.DropColumn(
                name: "Amargor",
                table: "Cerveja");

            migrationBuilder.DropColumn(
                name: "Aroma",
                table: "Cerveja");

            migrationBuilder.DropColumn(
                name: "CervejariaId",
                table: "Cerveja");

            migrationBuilder.DropColumn(
                name: "Coloracao",
                table: "Cerveja");

            migrationBuilder.DropColumn(
                name: "Foto",
                table: "Cerveja");

            migrationBuilder.DropColumn(
                name: "Historia",
                table: "Cerveja");

            migrationBuilder.DropColumn(
                name: "Origem",
                table: "Cerveja");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Avaliacao");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "UserToken",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "UserToken",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "UserLogin",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "UserLogin",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "Tipo",
                table: "TipoCerveja",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DescricaoTipo",
                table: "TipoCerveja",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NomeCerveja",
                table: "Cerveja",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DescricaoCerveja",
                table: "Cerveja",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Comentario",
                table: "Avaliacao",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true);
        }
    }
}
