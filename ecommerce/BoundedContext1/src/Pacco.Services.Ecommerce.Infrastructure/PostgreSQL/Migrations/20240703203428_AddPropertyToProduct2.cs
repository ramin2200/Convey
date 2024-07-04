using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pacco.Services.Ecommerce.Infrastructure.PostgreSQL.Migrations
{
    public partial class AddPropertyToProduct2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Tags",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Tags");
        }
    }
}
