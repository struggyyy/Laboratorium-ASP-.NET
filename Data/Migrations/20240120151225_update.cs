using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "16e6fb32-3de3-401c-b811-c7b49cade206", "b9049cfc-6843-4ad6-b4bc-e67711b01b61" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b84a9433-f826-4ddb-8290-27fc8b24e55c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "16e6fb32-3de3-401c-b811-c7b49cade206");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b9049cfc-6843-4ad6-b4bc-e67711b01b61");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "967e845c-3fcd-4242-88fa-ff63290ba762", "967e845c-3fcd-4242-88fa-ff63290ba762", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "63d26435-7a95-4cc0-bfa2-e52bd91aa460", 0, "a2d68f93-59f5-48bb-abe2-040267cda68f", "jakub@wsei.edu.pl", true, false, null, "JAKUB@WSEI.EDU.PL", "JAKUB", "AQAAAAEAACcQAAAAEM5hTuz+XUF075mAeic8ZeV115aWmluHnbbLl+NDYcuau/GWZI1mfLc/HwcVit7raA==", null, false, "3827acbb-d546-42ff-98ae-0796b88869c3", false, "Jakub" },
                    { "6856a6e2-968b-459a-bab4-f8095c78d285", 0, "7f4a4154-1312-48dd-bdaa-e2283c00080b", "adam@wsei.edu.pl", true, false, null, "ADAM@WSEI.EDU.PL", "ADAM", "AQAAAAEAACcQAAAAEJvZKHNRrNxyT2aTb1v7O4HVhwUtEyW/TqL6buZB+yx0Q/IPocJ5jflpRXaTYeDEjw==", null, false, "d585243f-641d-49fa-a793-04842d462bc6", false, "adam" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "967e845c-3fcd-4242-88fa-ff63290ba762", "6856a6e2-968b-459a-bab4-f8095c78d285" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "967e845c-3fcd-4242-88fa-ff63290ba762", "6856a6e2-968b-459a-bab4-f8095c78d285" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "63d26435-7a95-4cc0-bfa2-e52bd91aa460");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "967e845c-3fcd-4242-88fa-ff63290ba762");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6856a6e2-968b-459a-bab4-f8095c78d285");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "16e6fb32-3de3-401c-b811-c7b49cade206", "16e6fb32-3de3-401c-b811-c7b49cade206", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "b84a9433-f826-4ddb-8290-27fc8b24e55c", 0, "e21f6678-1de6-4375-9a11-a101b232795c", "jakub@wsei.edu.pl", true, false, null, "JAKUB@WSEI.EDU.PL", "JAKUB", "AQAAAAEAACcQAAAAEGo1IV/U/8+pNnwNxubCibYVQyhn8RRRLTrOu/+dc2NYoCIK9LFyJ13k9wvcG/8TNA==", null, false, "60bd97ef-e378-4377-bcb3-d7ac6453747d", false, "Jakub" },
                    { "b9049cfc-6843-4ad6-b4bc-e67711b01b61", 0, "6101baf4-4b6f-4de9-8752-5cb8a9560fe4", "adam@wsei.edu.pl", true, false, null, "ADAM@WSEI.EDU.PL", "ADAM", "AQAAAAEAACcQAAAAEEZNoVZgFen//TVIFZP2Vv8l5zVx2JOUcZGnVeTZcy0/+Dcq7pd3bXIixO9nSoM01w==", null, false, "75b759da-9f10-4729-8f3e-11a3ab1f18dd", false, "adam" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "16e6fb32-3de3-401c-b811-c7b49cade206", "b9049cfc-6843-4ad6-b4bc-e67711b01b61" });
        }
    }
}
