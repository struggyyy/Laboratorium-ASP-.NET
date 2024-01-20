using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class Organization : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d5650e03-ee6e-4213-ad93-3eccaa6f802c", "1201580a-c6f2-4e7e-a035-d2665128ab64" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bee58989-06a7-4417-94b8-d68544e22b28");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d5650e03-ee6e-4213-ad93-3eccaa6f802c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1201580a-c6f2-4e7e-a035-d2665128ab64");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "d5650e03-ee6e-4213-ad93-3eccaa6f802c", "d5650e03-ee6e-4213-ad93-3eccaa6f802c", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1201580a-c6f2-4e7e-a035-d2665128ab64", 0, "8877145d-9d22-430f-8450-4b49fa19841d", "adam@wsei.edu.pl", true, false, null, "ADAM@WSEI.EDU.PL", "ADAM", "AQAAAAEAACcQAAAAEOakDhVdSAV3HzrBWDi3z7rj/hgmcoZGW0KKqRs4igfEB/FRwjA6NdDciYQkC4AoQQ==", null, false, "eed3e848-525e-4433-982b-e5bf39bce9fc", false, "adam" },
                    { "bee58989-06a7-4417-94b8-d68544e22b28", 0, "057c579e-0417-4992-97c7-d15fdfd5d587", "jakub@wsei.edu.pl", true, false, null, "JAKUB@WSEI.EDU.PL", "JAKUB", "AQAAAAEAACcQAAAAEA/iTfPBcBgPFEWiWR1VpPLhWXFVDKb3MZVXBkq89NV+WIpwDgEJ5c5tFm20QP4FxA==", null, false, "1c91c707-c31f-462e-9d47-bd836bfa2673", false, "Jakub" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "d5650e03-ee6e-4213-ad93-3eccaa6f802c", "1201580a-c6f2-4e7e-a035-d2665128ab64" });
        }
    }
}
