using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TicketBookingApplication.Api.Migrations
{
    /// <inheritdoc />
    public partial class firstmigrat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "GenreId", "Name" },
                values: new object[,]
                {
                    { new Guid("ae61e5f1-4517-48e3-960e-812f7235c8fc"), "A hilarious comedy movie.", new Guid("a2c6f1b3-7520-4a90-baba-5cb0c00f8935"), "Comedy Movie 1" },
                    { new Guid("af47c5a9-0921-463e-b1a8-4c59b24b8f0e"), "A scary horror movie.", new Guid("29f7804a-54f8-4a72-aadb-cf4f3f6060a4"), "Horror Movie 1" },
                    { new Guid("bf35e5a2-3abf-4e2b-b0d4-31d84324e674"), "An emotional drama movie.", new Guid("b341cf42-64c5-4dfb-b0b6-4bb5d4b1f451"), "Drama Movie 1" },
                    { new Guid("cfe1b5d9-0f2b-4a24-b749-2e8bcb14a241"), "A magical fantasy movie.", new Guid("ef9a4a02-b59e-497e-82be-20d19f62e785"), "Fantasy Movie 1" },
                    { new Guid("d921a4e3-7f2a-467e-b93a-08fcb57b8e4e"), "A futuristic sci-fi movie.", new Guid("fde9f3a4-3558-4ddf-9349-b6e75fd8e92e"), "Sci-Fi Movie 1" },
                    { new Guid("de91c5e3-dab1-4d23-9f36-947f785b20b3"), "An exciting action movie.", new Guid("d3f1f8b0-19e6-4db6-8e91-a6fdee8a7611"), "Action Movie 1" },
                    { new Guid("fb12a8d2-1721-4c48-bd8b-4c7a12b1c1f3"), "A heartwarming romance movie.", new Guid("e0e4d9e2-d2b1-4c50-b4a7-ef3a8b21cde3"), "Romance Movie 1" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("ae61e5f1-4517-48e3-960e-812f7235c8fc"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("af47c5a9-0921-463e-b1a8-4c59b24b8f0e"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("bf35e5a2-3abf-4e2b-b0d4-31d84324e674"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("cfe1b5d9-0f2b-4a24-b749-2e8bcb14a241"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("d921a4e3-7f2a-467e-b93a-08fcb57b8e4e"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("de91c5e3-dab1-4d23-9f36-947f785b20b3"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("fb12a8d2-1721-4c48-bd8b-4c7a12b1c1f3"));
        }
    }
}
