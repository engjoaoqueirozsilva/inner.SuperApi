using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace inner.masterApi.Migrations
{
    public partial class Add_Modalidade_Atleta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ModalidadeTreino",
                table: "Treino",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.CreateTable(
                name: "Atleta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeAtleta = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PosicaoPreferencial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PosicaoSecundaria = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modalidade = table.Column<int>(type: "int", nullable: false),
                    RG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Endereço = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CEP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContatoEmergencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Obs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Atleta", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Modalidade",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeModalidade = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    RespTecnico = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AuxTecnico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Obs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modalidade", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Atleta");

            migrationBuilder.DropTable(
                name: "Modalidade");

            migrationBuilder.AlterColumn<string>(
                name: "ModalidadeTreino",
                table: "Treino",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
