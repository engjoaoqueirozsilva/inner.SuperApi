using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace inner.masterApi.Migrations
{
    public partial class Create_Treino : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Treino",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeTreino = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    ModalidadeTreino = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Fundamento1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fundamento2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fundamento3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fundamento4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fundamento5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fundamento6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Treino", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Treino");
        }
    }
}
