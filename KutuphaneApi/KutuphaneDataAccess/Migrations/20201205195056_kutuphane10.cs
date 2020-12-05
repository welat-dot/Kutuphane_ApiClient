using Microsoft.EntityFrameworkCore.Migrations;

namespace KutuphaneDataAccess.Migrations
{
    public partial class kutuphane10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "yazar_Ad_Soyad",
                table: "Yazars",
                maxLength: 65,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(60) CHARACTER SET utf8mb4",
                oldMaxLength: 60,
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "yazar_Ad_Soyad",
                table: "Yazars",
                type: "varchar(60) CHARACTER SET utf8mb4",
                maxLength: 60,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 65,
                oldNullable: true);
        }
    }
}
