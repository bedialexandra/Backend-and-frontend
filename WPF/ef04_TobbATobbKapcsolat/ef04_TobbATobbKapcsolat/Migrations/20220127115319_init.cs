using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ef04_TobbATobbKapcsolat.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Tanulok",
                columns: table => new
                {
                    tanuloId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    tanuloNev = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    szuletesiDatum = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tanulok", x => x.tanuloId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Teszt",
                columns: table => new
                {
                    tesztId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    tesztMegnevezes = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teszt", x => x.tesztId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tesztEredmenyek",
                columns: table => new
                {
                    tanuloId = table.Column<int>(type: "int", nullable: false),
                    tesztId = table.Column<int>(type: "int", nullable: false),
                    eredmeny = table.Column<int>(type: "int", nullable: false),
                    datum = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tesztEredmenyek", x => new { x.tanuloId, x.tesztId });
                    table.ForeignKey(
                        name: "FK_tesztEredmenyek_Tanulok_tanuloId",
                        column: x => x.tanuloId,
                        principalTable: "Tanulok",
                        principalColumn: "tanuloId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tesztEredmenyek_Teszt_tesztId",
                        column: x => x.tesztId,
                        principalTable: "Teszt",
                        principalColumn: "tesztId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_tesztEredmenyek_tesztId",
                table: "tesztEredmenyek",
                column: "tesztId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tesztEredmenyek");

            migrationBuilder.DropTable(
                name: "Tanulok");

            migrationBuilder.DropTable(
                name: "Teszt");
        }
    }
}
