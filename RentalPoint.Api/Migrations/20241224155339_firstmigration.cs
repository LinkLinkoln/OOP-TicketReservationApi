using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TicketBookingApplication.Api.Migrations
{
    /// <inheritdoc />
    public partial class firstmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("29f7804a-54f8-4a72-aadb-cf4f3f6060a4"), "Horror" },
                    { new Guid("a2c6f1b3-7520-4a90-baba-5cb0c00f8935"), "Comedy" },
                    { new Guid("b341cf42-64c5-4dfb-b0b6-4bb5d4b1f451"), "Drama" },
                    { new Guid("d3f1f8b0-19e6-4db6-8e91-a6fdee8a7611"), "Action" },
                    { new Guid("e0e4d9e2-d2b1-4c50-b4a7-ef3a8b21cde3"), "Romance" },
                    { new Guid("ef9a4a02-b59e-497e-82be-20d19f62e785"), "Fantasy" },
                    { new Guid("fde9f3a4-3558-4ddf-9349-b6e75fd8e92e"), "Sci-Fi" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("29f7804a-54f8-4a72-aadb-cf4f3f6060a4"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("a2c6f1b3-7520-4a90-baba-5cb0c00f8935"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("b341cf42-64c5-4dfb-b0b6-4bb5d4b1f451"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("d3f1f8b0-19e6-4db6-8e91-a6fdee8a7611"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("e0e4d9e2-d2b1-4c50-b4a7-ef3a8b21cde3"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("ef9a4a02-b59e-497e-82be-20d19f62e785"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("fde9f3a4-3558-4ddf-9349-b6e75fd8e92e"));
        }
    }
}
