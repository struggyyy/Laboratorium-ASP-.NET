using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class Identity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "330aacc7-590d-4b5c-b03d-f71ad4c032c3", "ee78f745-5e15-4898-9999-2c6efefa0173" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c36ce65-8557-4481-97c1-10a05d3e7b6e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "330aacc7-590d-4b5c-b03d-f71ad4c032c3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ee78f745-5e15-4898-9999-2c6efefa0173");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "330aacc7-590d-4b5c-b03d-f71ad4c032c3", "330aacc7-590d-4b5c-b03d-f71ad4c032c3", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2c36ce65-8557-4481-97c1-10a05d3e7b6e", 0, "db46a7f3-c7e5-40c6-b169-d0c953681ae7", "jakub@wsei.edu.pl", true, false, null, "JAKUB@WSEI.EDU.PL", "JAKUB", "AQAAAAEAACcQAAAAENoXJwC8RApCiNmP1rJjsjN/9AmzVsRxxnOX/Ep5ktgEV+9ABA1YN3yMDhdmqkWrxQ==", null, false, "ba9b33a8-3325-41ff-8516-2ab5a33ff8fa", false, "Jakub" },
                    { "ee78f745-5e15-4898-9999-2c6efefa0173", 0, "38906ba0-84a6-4192-ba7f-dad2f4bb6a4a", "adam@wsei.edu.pl", true, false, null, "ADAM@WSEI.EDU.PL", "ADAM", "AQAAAAEAACcQAAAAEEFSS/6Swv1E/1Wf2Kipw+JDgCBNRsn9VfogFvHz+BZ71xJDhKLL8AYUeNZ2OpFKuw==", null, false, "f112d955-8fc2-4793-b05e-2ff2c5fae863", false, "adam" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "330aacc7-590d-4b5c-b03d-f71ad4c032c3", "ee78f745-5e15-4898-9999-2c6efefa0173" });
        }
    }
}
