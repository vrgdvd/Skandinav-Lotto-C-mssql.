using Microsoft.EntityFrameworkCore.Migrations;

namespace LottoAdatKapcsolatt.Migrations
{
    public partial class elsoooone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Szam6",
                table: "LottoSzamok",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Szam7",
                table: "LottoSzamok",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Szam6",
                table: "LottoSzamok");

            migrationBuilder.DropColumn(
                name: "Szam7",
                table: "LottoSzamok");
        }
    }
}
