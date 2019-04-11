using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace blog.Migrations
{
    public partial class contactDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ContactMessage",
                table: "Contacts",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<DateTime>(
                name: "ContactDate",
                table: "Contacts",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContactDate",
                table: "Contacts");

            migrationBuilder.AlterColumn<int>(
                name: "ContactMessage",
                table: "Contacts",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
