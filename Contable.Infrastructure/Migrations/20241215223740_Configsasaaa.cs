using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Contable.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Configsasaaa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Enterprises");

            migrationBuilder.DropColumn(
                name: "PaymentsId",
                table: "Enterprises");

            migrationBuilder.DropColumn(
                name: "RegimeId",
                table: "Enterprises");

            migrationBuilder.DropColumn(
                name: "Ruc",
                table: "Enterprises");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "AddressId",
                table: "Enterprises",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "PaymentsId",
                table: "Enterprises",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "RegimeId",
                table: "Enterprises",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "Ruc",
                table: "Enterprises",
                type: "int",
                nullable: true);
        }
    }
}
