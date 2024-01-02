using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

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
                keyValues: new object[] { "87995ae6-27b0-40d0-918a-94c0dbcfc937", "ec016fed-fb7e-4da9-ab72-9f17c4e63e34" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "87995ae6-27b0-40d0-918a-94c0dbcfc937");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ec016fed-fb7e-4da9-ab72-9f17c4e63e34");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "98b6f8bd-3d72-4f49-871d-d25510620d0e", "98b6f8bd-3d72-4f49-871d-d25510620d0e", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "08cf2a78-d4d1-4a78-8215-56e0f0e1fe07", 0, "a7bb3bd6-d643-4f11-8ff2-d7dc328ffb21", "adam@wsei.edu.pl", true, false, null, "ADAM@WSEI.EDU.PL", "ADAM", "AQAAAAEAACcQAAAAEBuUUvR2TcA44koGoEB990bSI0QVQ7x2QniceC3Z+hwjtTTcq9wdFG5fqWz40vs44g==", null, false, "9ee595fc-84f3-4df2-a8bd-e768bcd92243", false, "adam" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "98b6f8bd-3d72-4f49-871d-d25510620d0e", "08cf2a78-d4d1-4a78-8215-56e0f0e1fe07" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "98b6f8bd-3d72-4f49-871d-d25510620d0e", "08cf2a78-d4d1-4a78-8215-56e0f0e1fe07" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "98b6f8bd-3d72-4f49-871d-d25510620d0e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "08cf2a78-d4d1-4a78-8215-56e0f0e1fe07");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "87995ae6-27b0-40d0-918a-94c0dbcfc937", "87995ae6-27b0-40d0-918a-94c0dbcfc937", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ec016fed-fb7e-4da9-ab72-9f17c4e63e34", 0, "cdd82955-7c65-465f-b15c-5331d1214184", "adam@wsei.edu.pl", true, false, null, "ADAM@WSEI.EDU.PL", "ADAM", "AQAAAAEAACcQAAAAEOcsFE4t4lT972AVrL2bSKpL1t4a8OZ6y+JlMqwmUamd2ok7eT+ehEA5D+38HA9P3g==", null, false, "a6bb392f-8e10-47cc-acb9-c971b1dd16c6", false, "adam" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "87995ae6-27b0-40d0-918a-94c0dbcfc937", "ec016fed-fb7e-4da9-ab72-9f17c4e63e34" });
        }
    }
}
