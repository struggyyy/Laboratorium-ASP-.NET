using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a44623c3-21f6-44ae-8d44-b02c0a50d4c2", "76e5c4af-0351-4deb-973b-e334bd644c08" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "66f749ef-6fcd-4326-a670-16b3c9238791");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a44623c3-21f6-44ae-8d44-b02c0a50d4c2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "76e5c4af-0351-4deb-973b-e334bd644c08");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9d49d9a5-363a-470a-9c15-3b9c417f4869", "9d49d9a5-363a-470a-9c15-3b9c417f4869", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1d1bd126-0148-4f3d-bfd4-2feb5cffd506", 0, "12b1da72-f900-4332-bc18-6539c1e11e79", "jakub@wsei.edu.pl", true, false, null, "JAKUB@WSEI.EDU.PL", "JAKUB", "AQAAAAEAACcQAAAAEBtb6fBR6rproWVTNdqHidty3XNr37Si87uH45NUSx7hsMd4P8KNBzr3MaciEv5KVg==", null, false, "5a36e771-f15e-4925-8be1-1eaa8433d86c", false, "Jakub" },
                    { "7b724861-eb0f-4c90-b7a2-7183612cfe35", 0, "df50a4f2-1878-4630-b9f8-4308e7dba896", "adam@wsei.edu.pl", true, false, null, "ADAM@WSEI.EDU.PL", "ADAM", "AQAAAAEAACcQAAAAEC4kQqraDL63SF3eUepBmMG0Jt8GDIdH0Wv6NAODI9sISGzuvXnO7T6/6/stS59sfw==", null, false, "ed9741f8-5235-477d-9343-5089e30d0978", false, "adam" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "9d49d9a5-363a-470a-9c15-3b9c417f4869", "7b724861-eb0f-4c90-b7a2-7183612cfe35" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9d49d9a5-363a-470a-9c15-3b9c417f4869", "7b724861-eb0f-4c90-b7a2-7183612cfe35" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1d1bd126-0148-4f3d-bfd4-2feb5cffd506");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d49d9a5-363a-470a-9c15-3b9c417f4869");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7b724861-eb0f-4c90-b7a2-7183612cfe35");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a44623c3-21f6-44ae-8d44-b02c0a50d4c2", "a44623c3-21f6-44ae-8d44-b02c0a50d4c2", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "66f749ef-6fcd-4326-a670-16b3c9238791", 0, "f1d82d02-a687-4c44-80c7-9f89382f61af", "jakub@wsei.edu.pl", true, false, null, "JAKUB@WSEI.EDU.PL", "JAKUB", "AQAAAAEAACcQAAAAEKfXuAWalf5NGq5P6xt4FsoaeGgSlZacl5f/jhs682Kgoqg23vOwFplFTwpdN9ynLw==", null, false, "3ca366e5-fea8-4d5b-a412-2bb065999ba5", false, "Jakub" },
                    { "76e5c4af-0351-4deb-973b-e334bd644c08", 0, "56747226-626a-43e1-a7e0-2edf69925394", "adam@wsei.edu.pl", true, false, null, "ADAM@WSEI.EDU.PL", "ADAM", "AQAAAAEAACcQAAAAEBJGd5JBjljc6xN1Mq+dxiv0teKStmovsxLwVw8B3l0P+FpGLeKmBKvcGqgkF/TX6Q==", null, false, "c88d3c4d-33b6-4e45-b1de-3cec8456f6c5", false, "adam" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a44623c3-21f6-44ae-8d44-b02c0a50d4c2", "76e5c4af-0351-4deb-973b-e334bd644c08" });
        }
    }
}
