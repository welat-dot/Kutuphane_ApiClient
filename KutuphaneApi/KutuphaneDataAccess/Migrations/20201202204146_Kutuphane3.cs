using Microsoft.EntityFrameworkCore.Migrations;

namespace KutuphaneDataAccess.Migrations
{
    public partial class Kutuphane3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "okunan_KitapSayisi",
                table: "Uyes");

            migrationBuilder.AddColumn<int>(
                name: "okunan_KitapSayi",
                table: "Uyes",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "okunan_KitapSayi",
                table: "Uyes");

            migrationBuilder.AddColumn<int>(
                name: "okunan_KitapSayisi",
                table: "Uyes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
