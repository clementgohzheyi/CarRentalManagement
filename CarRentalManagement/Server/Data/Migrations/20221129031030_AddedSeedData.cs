using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "75d70558-9596-4c63-bedd-578ab0b43fea", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "9bd925c2-55ea-4d51-a7d3-3c780fdd9967", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAEEu+jjCuTZzC6yJJnVa+e2byqELy5qMAx4iEerTb2Eq/WU5QevO4eeqUEzOvP8PduQ==", null, false, "de1aa1c3-6290-46f4-928d-07c8a8cc5715", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 11, 29, 11, 10, 28, 954, DateTimeKind.Local).AddTicks(1524), new DateTime(2022, 11, 29, 11, 10, 28, 956, DateTimeKind.Local).AddTicks(1489), "Black", "System" },
                    { 2, "System", new DateTime(2022, 11, 29, 11, 10, 28, 956, DateTimeKind.Local).AddTicks(5415), new DateTime(2022, 11, 29, 11, 10, 28, 956, DateTimeKind.Local).AddTicks(5436), "Black", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 11, 29, 11, 10, 28, 959, DateTimeKind.Local).AddTicks(1957), new DateTime(2022, 11, 29, 11, 10, 28, 959, DateTimeKind.Local).AddTicks(1992), "BMW", "System" },
                    { 2, "System", new DateTime(2022, 11, 29, 11, 10, 28, 959, DateTimeKind.Local).AddTicks(2000), new DateTime(2022, 11, 29, 11, 10, 28, 959, DateTimeKind.Local).AddTicks(2002), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 11, 29, 11, 10, 28, 960, DateTimeKind.Local).AddTicks(6828), new DateTime(2022, 11, 29, 11, 10, 28, 960, DateTimeKind.Local).AddTicks(6859), "3 Series", "System" },
                    { 2, "System", new DateTime(2022, 11, 29, 11, 10, 28, 960, DateTimeKind.Local).AddTicks(6870), new DateTime(2022, 11, 29, 11, 10, 28, 960, DateTimeKind.Local).AddTicks(6873), "X5", "System" },
                    { 3, "System", new DateTime(2022, 11, 29, 11, 10, 28, 960, DateTimeKind.Local).AddTicks(6876), new DateTime(2022, 11, 29, 11, 10, 28, 960, DateTimeKind.Local).AddTicks(6879), "Prius", "System" },
                    { 4, "System", new DateTime(2022, 11, 29, 11, 10, 28, 960, DateTimeKind.Local).AddTicks(6972), new DateTime(2022, 11, 29, 11, 10, 28, 960, DateTimeKind.Local).AddTicks(6974), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}
