using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FullStack.Data.Migrations
{
    public partial class ClassPersistence : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    InvoiceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceDate = table.Column<DateTimeOffset>(nullable: false),
                    InvoiceRefNumber = table.Column<string>(nullable: true),
                    InvoiceDueDate = table.Column<DateTimeOffset>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.InvoiceId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Forenames = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Role = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceItems",
                columns: table => new
                {
                    InvoiceItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true),
                    RatePerHour = table.Column<decimal>(nullable: false),
                    HoursWorked = table.Column<decimal>(nullable: false),
                    InvoiceId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceItems", x => x.InvoiceItemId);
                    table.ForeignKey(
                        name: "FK_InvoiceItems_Invoices_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "Invoices",
                        principalColumn: "InvoiceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "InvoiceId", "InvoiceDate", "InvoiceDueDate", "InvoiceRefNumber" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2020, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), "invoice001" },
                    { 2, new DateTimeOffset(new DateTime(2020, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), "invoice002" },
                    { 3, new DateTimeOffset(new DateTime(2021, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), "invoice003" },
                    { 4, new DateTimeOffset(new DateTime(2021, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), "invoice004" },
                    { 5, new DateTimeOffset(new DateTime(2021, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), "invoice005" },
                    { 6, new DateTimeOffset(new DateTime(2021, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), "invoice006" },
                    { 7, new DateTimeOffset(new DateTime(2021, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), "invoice007" },
                    { 8, new DateTimeOffset(new DateTime(2021, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), "invoice008" },
                    { 9, new DateTimeOffset(new DateTime(2021, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), "invoice009" },
                    { 10, new DateTimeOffset(new DateTime(2021, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), "invoice010" },
                    { 11, new DateTimeOffset(new DateTime(2021, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), "invoice011" },
                    { 12, new DateTimeOffset(new DateTime(2021, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), "invoice012" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Forenames", "Password", "Role", "Surname" },
                values: new object[,]
                {
                    { 1, null, "Admin", "administration", "Admin", "User" },
                    { 2, null, "Anthony", "administration", "User", "Coder" }
                });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "InvoiceItemId", "Description", "HoursWorked", "InvoiceId", "RatePerHour" },
                values: new object[,]
                {
                    { 1, "Desktop Technology Support", 400m, 1, 84m },
                    { 27, "Desktop Technology Support", 200m, 11, 400m },
                    { 26, "Desktop Technology Support", 300m, 11, 84m },
                    { 25, "Desktop Technology Support", 200m, 10, 84m },
                    { 24, "Desktop Technology Support", 300m, 10, 84m },
                    { 23, "Full web maintenance", 450m, 9, 789m },
                    { 22, "Full web maintenance", 960m, 9, 400m },
                    { 21, "Desktop Technology Support", 479m, 8, 9876m },
                    { 20, "Desktop Technology Support", 479m, 8, 9876m },
                    { 19, "Desktop Technology Support", 200m, 8, 400m },
                    { 18, "Desktop Technology Support", 300m, 8, 84m },
                    { 17, "Security patches & CMS updates", 200m, 7, 400m },
                    { 16, "Security patches & CMS updates", 200m, 7, 400m },
                    { 28, "Desktop Technology Support", 300m, 12, 84m },
                    { 15, "After-hour maintenance", 250m, 7, 89m },
                    { 13, "Desktop Technology Support", 300m, 6, 695m },
                    { 12, "Premier Consulting Services", 300m, 5, 84m },
                    { 11, "Network/Server Technology", 300m, 4, 579m },
                    { 10, "Security patches & CMS updates", 300m, 4, 84m },
                    { 9, "Full web maintenance", 300m, 4, 84m },
                    { 8, "After-hours maintenance", 1000m, 3, 1200m },
                    { 7, "Security patches & CMS updates", 265m, 3, 578m },
                    { 6, "Advanced Technology Support", 487m, 3, 84m },
                    { 5, "Desktop Technology Support", 200m, 2, 400m },
                    { 4, "Desktop Technology Support", 300m, 2, 84m },
                    { 3, "Security patches & CMS updates", 200m, 1, 400m },
                    { 2, "Network/Server Technolody Support", 365m, 1, 91m },
                    { 14, "Desktop Technology Support", 987m, 6, 789m },
                    { 29, "Desktop Technology Support", 200m, 12, 400m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceItems_InvoiceId",
                table: "InvoiceItems",
                column: "InvoiceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InvoiceItems");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Invoices");
        }
    }
}
