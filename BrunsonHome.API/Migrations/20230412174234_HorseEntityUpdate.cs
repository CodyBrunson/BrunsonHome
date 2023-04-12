using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BrunsonHome.API.Migrations
{
    /// <inheritdoc />
    public partial class HorseEntityUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "PurchaseDate",
                table: "Horses",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PurchaseDate",
                table: "Horses");
        }
    }
}
