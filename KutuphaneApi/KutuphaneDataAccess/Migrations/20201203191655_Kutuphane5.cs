using Microsoft.EntityFrameworkCore.Migrations;

namespace KutuphaneDataAccess.Migrations
{
    public partial class Kutuphane5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_kitaps_Yazars_yazarId",
                table: "kitaps");

            migrationBuilder.DropIndex(
                name: "IX_kitaps_yazarId",
                table: "kitaps");

            migrationBuilder.DropColumn(
                name: "yazarId",
                table: "kitaps");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "yazarId",
                table: "kitaps",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_kitaps_yazarId",
                table: "kitaps",
                column: "yazarId");

            migrationBuilder.AddForeignKey(
                name: "FK_kitaps_Yazars_yazarId",
                table: "kitaps",
                column: "yazarId",
                principalTable: "Yazars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
