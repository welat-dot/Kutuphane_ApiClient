using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KutuphaneDataAccess.Migrations
{
    public partial class Kutuphane1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Uyes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    uye_Adi = table.Column<int>(maxLength: 50, nullable: false),
                    uye_Soy_Adi = table.Column<int>(maxLength: 50, nullable: false),
                    okunan_KitapSayisi = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uyes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Yazars",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    yazar_Ad_Soyad = table.Column<string>(maxLength: 50, nullable: true),
                    yazar_Kitap_Sayisi = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yazars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "kitaps",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    kitap_adi = table.Column<string>(maxLength: 50, nullable: true),
                    yazar_id = table.Column<int>(nullable: false),
                    sayfaSayisi = table.Column<int>(nullable: false),
                    yazarId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kitaps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_kitaps_Yazars_yazarId",
                        column: x => x.yazarId,
                        principalTable: "Yazars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_kitaps_yazarId",
                table: "kitaps",
                column: "yazarId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "kitaps");

            migrationBuilder.DropTable(
                name: "Uyes");

            migrationBuilder.DropTable(
                name: "Yazars");
        }
    }
}
