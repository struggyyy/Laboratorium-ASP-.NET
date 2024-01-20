using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class addUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6d98415b-4ae4-47b8-a385-b5571c715858", "a0bfc99b-9450-4202-9540-13cf21455f24" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b8d3b8a-cec1-4bd8-9030-a29418272431");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6d98415b-4ae4-47b8-a385-b5571c715858");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a0bfc99b-9450-4202-9540-13cf21455f24");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "6d98415b-4ae4-47b8-a385-b5571c715858", "6d98415b-4ae4-47b8-a385-b5571c715858", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6b8d3b8a-cec1-4bd8-9030-a29418272431", 0, "ecff4cf5-73d2-4f2f-9d13-2f8379f650b4", "jakub@wsei.edu.pl", true, false, null, "JAKUB@WSEI.EDU.PL", "JAKUB", "AQAAAAEAACcQAAAAECtzv1BHaY5wZ+7pueKECP26Oh/r4Tcv9WCcsmt37XbshN/TJ71bsNrZ8OXKVQSujg==", null, false, "c7e0a412-2fa3-4348-a713-e27acac199e2", false, "Jakub" },
                    { "a0bfc99b-9450-4202-9540-13cf21455f24", 0, "7f16c9a7-7818-4083-ab1a-5c883711e060", "adam@wsei.edu.pl", true, false, null, "ADAM@WSEI.EDU.PL", "ADAM", "AQAAAAEAACcQAAAAEKR4bo8Yw1MXUDDqsr+g2BP7POVnercg69DWSPg+5RwNCosY2SkJDhQrMWL0LKiYeQ==", null, false, "651ffe86-b361-49ff-a441-c6ed161e4e1b", false, "adam" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "6d98415b-4ae4-47b8-a385-b5571c715858", "a0bfc99b-9450-4202-9540-13cf21455f24" });
        }
    }
}
