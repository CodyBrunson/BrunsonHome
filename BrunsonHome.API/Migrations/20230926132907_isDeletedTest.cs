using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BrunsonHome.API.Migrations
{
    /// <inheritdoc />
    public partial class isDeletedTest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "AddDate",
                table: "Wormings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateDeleted",
                table: "Wormings",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Wormings",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "Wormings",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateDeleted",
                table: "Horses",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "Horses",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "AddDate",
                table: "FootTrims",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateDeleted",
                table: "FootTrims",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "FootTrims",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "FootTrims",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddDate",
                table: "Wormings");

            migrationBuilder.DropColumn(
                name: "DateDeleted",
                table: "Wormings");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Wormings");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "Wormings");

            migrationBuilder.DropColumn(
                name: "DateDeleted",
                table: "Horses");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "Horses");

            migrationBuilder.DropColumn(
                name: "AddDate",
                table: "FootTrims");

            migrationBuilder.DropColumn(
                name: "DateDeleted",
                table: "FootTrims");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "FootTrims");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "FootTrims");
        }
    }
}
