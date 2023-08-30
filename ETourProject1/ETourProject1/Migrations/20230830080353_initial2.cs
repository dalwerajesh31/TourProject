using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ETourProject1.Migrations
{
    /// <inheritdoc />
    public partial class initial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "bookingDate",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "customerId",
                table: "Bookings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "departureId",
                table: "Bookings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "numberOfPassengers",
                table: "Bookings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "packageId",
                table: "Bookings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "taxes",
                table: "Bookings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "totalAmount",
                table: "Bookings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "tourAmount",
                table: "Bookings",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "bookingDate",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "customerId",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "departureId",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "numberOfPassengers",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "packageId",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "taxes",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "totalAmount",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "tourAmount",
                table: "Bookings");
        }
    }
}
