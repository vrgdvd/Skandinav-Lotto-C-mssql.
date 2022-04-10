﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace LottoAdatKapcsolatt.Migrations
{
    public partial class els : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LottoSzamok",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Szam1 = table.Column<int>(type: "int", nullable: false),
                    Szam2 = table.Column<int>(type: "int", nullable: false),
                    Szam3 = table.Column<int>(type: "int", nullable: false),
                    Szam4 = table.Column<int>(type: "int", nullable: false),
                    Szam5 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LottoSzamok", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LottoSzamok");
        }
    }
}
