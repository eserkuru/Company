using Microsoft.EntityFrameworkCore.Migrations;

namespace Company.Manager.DataAccess.Migrations
{
    public partial class u_Country : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Country",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Country",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
