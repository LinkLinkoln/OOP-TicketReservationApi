using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TicketBookingApplication.Api.Migrations
{
    /// <inheritdoc />
    public partial class seedMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("12b7e4a5-93f6-4b82-b721-4c5a8d9f1c32"), "john.doe1@example.com", "John", "Doe", "+1234567890" },
                    { new Guid("1e7b4c5a-9f21-4a8f-b2d3-5c7a8f4d9b1f"), "emily.clark6@example.com", "Emily", "Clark", "+1234567895" },
                    { new Guid("29f7c5a8-41d3-44f2-b9f4-2c8d7a1b5f12"), "jane.smith2@example.com", "Jane", "Smith", "+1234567891" },
                    { new Guid("3b9f4a5d-7f2c-4d1b-b921-8c5f7a2b4d1c"), "bob.taylor4@example.com", "Bob", "Taylor", "+1234567893" },
                    { new Guid("5c7a9f4b-2d7e-4b1f-b93a-7a8f5c4d9b3e"), "frank.white7@example.com", "Frank", "White", "+1234567896" },
                    { new Guid("7f2c8d9a-41b5-4d7f-b12e-4a9f5c7a8d32"), "charlie.davis5@example.com", "Charlie", "Davis", "+1234567894" },
                    { new Guid("8f2c9b7a-14d6-4a5b-b93e-7f2a4d8b5c7f"), "alice.brown3@example.com", "Alice", "Brown", "+1234567892" }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "AvailableQuantity", "MovieId", "Price", "StartAt" },
                values: new object[,]
                {
                    { new Guid("1e9b7f32-4d2a-42b1-9723-8f4b9c7a8d5c"), 10, new Guid("fb12a8d2-1721-4c48-bd8b-4c7a12b1c1f3"), 14.99m, new DateTime(2024, 12, 24, 23, 5, 8, 550, DateTimeKind.Utc).AddTicks(4929) },
                    { new Guid("22b9d7b1-4c32-459a-bf71-1e9bcd16a7d5"), 50, new Guid("de91c5e3-dab1-4d23-9f36-947f785b20b3"), 10.99m, new DateTime(2024, 12, 24, 17, 5, 8, 550, DateTimeKind.Utc).AddTicks(4904) },
                    { new Guid("34a5c9f4-6123-48e6-b2c4-5db7c9a5a54e"), 20, new Guid("bf35e5a2-3abf-4e2b-b0d4-31d84324e674"), 12.99m, new DateTime(2024, 12, 24, 19, 5, 8, 550, DateTimeKind.Utc).AddTicks(4921) },
                    { new Guid("4a3bc7d5-53f6-4e2b-b4d6-94a81c2f574d"), 30, new Guid("ae61e5f1-4517-48e3-960e-812f7235c8fc"), 9.99m, new DateTime(2024, 12, 24, 18, 5, 8, 550, DateTimeKind.Utc).AddTicks(4918) },
                    { new Guid("5d7e4b32-1f8a-482f-b7f1-1e3c9b8f0a8b"), 15, new Guid("d921a4e3-7f2a-467e-b93a-08fcb57b8e4e"), 13.99m, new DateTime(2024, 12, 24, 22, 5, 8, 550, DateTimeKind.Utc).AddTicks(4927) },
                    { new Guid("89f7b5d3-4128-489b-9487-ef21c4b8e5f3"), 40, new Guid("af47c5a9-0921-463e-b1a8-4c59b24b8f0e"), 8.99m, new DateTime(2024, 12, 24, 20, 5, 8, 550, DateTimeKind.Utc).AddTicks(4923) },
                    { new Guid("8f1c9b42-0f1d-44f2-b14b-812c9b8c5d7f"), 25, new Guid("cfe1b5d9-0f2b-4a24-b749-2e8bcb14a241"), 11.99m, new DateTime(2024, 12, 24, 21, 5, 8, 550, DateTimeKind.Utc).AddTicks(4924) }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "ClientId", "SessionId" },
                values: new object[,]
                {
                    { new Guid("1e7a9f4c-3d5b-4f8a-b92e-7f4d1b5c8a32"), new Guid("3b9f4a5d-7f2c-4d1b-b921-8c5f7a2b4d1c"), new Guid("89f7b5d3-4128-489b-9487-ef21c4b8e5f3") },
                    { new Guid("2d3f7b8e-4c1a-5d9f-b72e-8a4c9f1d3b52"), new Guid("1e7b4c5a-9f21-4a8f-b2d3-5c7a8f4d9b1f"), new Guid("5d7e4b32-1f8a-482f-b7f1-1e3c9b8f0a8b") },
                    { new Guid("3a9f4b7e-1c2b-4d5a-b93e-7f4d9c1a8b52"), new Guid("29f7c5a8-41d3-44f2-b9f4-2c8d7a1b5f12"), new Guid("4a3bc7d5-53f6-4e2b-b4d6-94a81c2f574d") },
                    { new Guid("4b9f2a7c-8d1f-3e5b-b74a-9f3c2d8a7e52"), new Guid("5c7a9f4b-2d7e-4b1f-b93a-7a8f5c4d9b3e"), new Guid("1e9b7f32-4d2a-42b1-9723-8f4b9c7a8d5c") },
                    { new Guid("5c7f8d4a-92b1-4e7f-b9d2-7a1b5f4d8a32"), new Guid("7f2c8d9a-41b5-4d7f-b12e-4a9f5c7a8d32"), new Guid("8f1c9b42-0f1d-44f2-b14b-812c9b8c5d7f") },
                    { new Guid("7a8f5c4d-2b9f-4b1e-b7d3-8c4a9f1b5e32"), new Guid("8f2c9b7a-14d6-4a5b-b93e-7f2a4d8b5c7f"), new Guid("34a5c9f4-6123-48e6-b2c4-5db7c9a5a54e") },
                    { new Guid("8d5f7a4c-92b7-4a1d-b5f2-7a8d9c4b1e32"), new Guid("12b7e4a5-93f6-4b82-b721-4c5a8d9f1c32"), new Guid("22b9d7b1-4c32-459a-bf71-1e9bcd16a7d5") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("1e7a9f4c-3d5b-4f8a-b92e-7f4d1b5c8a32"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("2d3f7b8e-4c1a-5d9f-b72e-8a4c9f1d3b52"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("3a9f4b7e-1c2b-4d5a-b93e-7f4d9c1a8b52"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("4b9f2a7c-8d1f-3e5b-b74a-9f3c2d8a7e52"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("5c7f8d4a-92b1-4e7f-b9d2-7a1b5f4d8a32"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("7a8f5c4d-2b9f-4b1e-b7d3-8c4a9f1b5e32"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("8d5f7a4c-92b7-4a1d-b5f2-7a8d9c4b1e32"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("12b7e4a5-93f6-4b82-b721-4c5a8d9f1c32"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("1e7b4c5a-9f21-4a8f-b2d3-5c7a8f4d9b1f"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("29f7c5a8-41d3-44f2-b9f4-2c8d7a1b5f12"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("3b9f4a5d-7f2c-4d1b-b921-8c5f7a2b4d1c"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("5c7a9f4b-2d7e-4b1f-b93a-7a8f5c4d9b3e"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("7f2c8d9a-41b5-4d7f-b12e-4a9f5c7a8d32"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("8f2c9b7a-14d6-4a5b-b93e-7f2a4d8b5c7f"));

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: new Guid("1e9b7f32-4d2a-42b1-9723-8f4b9c7a8d5c"));

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: new Guid("22b9d7b1-4c32-459a-bf71-1e9bcd16a7d5"));

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: new Guid("34a5c9f4-6123-48e6-b2c4-5db7c9a5a54e"));

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: new Guid("4a3bc7d5-53f6-4e2b-b4d6-94a81c2f574d"));

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: new Guid("5d7e4b32-1f8a-482f-b7f1-1e3c9b8f0a8b"));

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: new Guid("89f7b5d3-4128-489b-9487-ef21c4b8e5f3"));

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: new Guid("8f1c9b42-0f1d-44f2-b14b-812c9b8c5d7f"));
        }
    }
}
