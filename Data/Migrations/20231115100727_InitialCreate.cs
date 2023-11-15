using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "albums",
                columns: table => new
                {
                    AlbumId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Band = table.Column<string>(type: "TEXT", nullable: false),
                    TrackList = table.Column<string>(type: "TEXT", nullable: false),
                    Record = table.Column<uint>(type: "INTEGER", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Duration = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_albums", x => x.AlbumId);
                });

            migrationBuilder.CreateTable(
                name: "contacts",
                columns: table => new
                {
                    ContactId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Phone = table.Column<string>(type: "TEXT", nullable: true),
                    Birth = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contacts", x => x.ContactId);
                });

            migrationBuilder.InsertData(
                table: "albums",
                columns: new[] { "AlbumId", "Band", "Duration", "name", "Record", "ReleaseDate", "TrackList" },
                values: new object[,]
                {
                    { 1, "Metallica", new DateTime(2023, 11, 15, 1, 5, 0, 0, DateTimeKind.Unspecified), "...And Justice for All", 0u, new DateTime(1988, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "1.Blackened 2. ...And Justice for All 3. Eye of the Beholder" },
                    { 2, "Metallica", new DateTime(2023, 11, 15, 1, 5, 0, 0, DateTimeKind.Unspecified), "...And Justice for All", 0u, new DateTime(1988, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "1.Blackened 2. ...And Justice for All 3. Eye of the Beholder" },
                    { 3, "Metallica", new DateTime(2023, 11, 15, 1, 5, 0, 0, DateTimeKind.Unspecified), "...And Justice for All", 0u, new DateTime(1988, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "1.Blackened 2. ...And Justice for All 3. Eye of the Beholder" }
                });

            migrationBuilder.InsertData(
                table: "contacts",
                columns: new[] { "ContactId", "Birth", "Email", "name", "Phone" },
                values: new object[,]
                {
                    { 1, new DateTime(2000, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "adam@wsei.pl", "Adam", "354353637" },
                    { 2, new DateTime(2002, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "jakubstr@gmail.com", "Jakub", "123234345" },
                    { 3, new DateTime(1999, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "cooldylan@gmail.com", "Dylan", "456567678" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "albums");

            migrationBuilder.DropTable(
                name: "contacts");
        }
    }
}
