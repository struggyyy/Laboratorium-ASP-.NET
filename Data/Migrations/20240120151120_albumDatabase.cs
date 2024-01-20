using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class albumDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
