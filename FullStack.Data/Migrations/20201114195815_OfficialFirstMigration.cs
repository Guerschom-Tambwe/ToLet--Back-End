using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FullStack.Data.Migrations
{
    public partial class OfficialFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adverts",
                columns: table => new
                {
                    AdvertId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Headline = table.Column<string>(nullable: true),
                    Province = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    AdvertDetails = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    AdvertStatus = table.Column<string>(nullable: true),
                    publishedDate = table.Column<DateTimeOffset>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adverts", x => x.AdvertId);
                });

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
                name: "Provinces",
                columns: table => new
                {
                    ProvinceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProvinceName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provinces", x => x.ProvinceId);
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
                    ConfirmPassword = table.Column<string>(nullable: true),
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

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CityId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(nullable: true),
                    ProvinceId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CityId);
                    table.ForeignKey(
                        name: "FK_Cities_Provinces_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "Provinces",
                        principalColumn: "ProvinceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Adverts",
                columns: new[] { "AdvertId", "AdvertDetails", "AdvertStatus", "City", "Headline", "Price", "Province", "UserId", "publishedDate" },
                values: new object[] { 1, "This is the very first advert", "LIVE", "Belville", "Very First Headline", 12.98m, "Western Cape", 2, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "ProvinceId", "ProvinceName" },
                values: new object[,]
                {
                    { 1, "Western Cape" },
                    { 2, "Northern Cape" },
                    { 3, "North West" },
                    { 4, "Gauteng" },
                    { 5, "Free State" },
                    { 6, "Limpop" },
                    { 7, "Eastern Cape" },
                    { 8, "Kwazulu-Natal" },
                    { 9, "Mpumalangae" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "ConfirmPassword", "Email", "Forenames", "Password", "Role", "Surname" },
                values: new object[,]
                {
                    { 1, "administration", "admin@test.com", "Admin", "administration", "Admin", "User" },
                    { 2, "administration", "anthonyCoder@gmail.com", "Anthony", "administration", "User", "Coder" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "CityName", "ProvinceId" },
                values: new object[,]
                {
                    { 29, "Bellville", 1 },
                    { 20, "Musina", 6 },
                    { 21, "Polokwane", 6 },
                    { 22, "Lebowakgomo", 6 },
                    { 23, "Sibasa", 6 },
                    { 24, "Phalaborwa", 6 },
                    { 1, "Alice", 7 },
                    { 8, "Welkom", 5 },
                    { 2, "Port Elizabeth", 7 },
                    { 4, "East London", 7 },
                    { 25, "Durban", 8 },
                    { 26, "Pinetown", 8 },
                    { 27, "Pietermaritzburg", 8 },
                    { 28, "Umlazi", 8 },
                    { 33, "Nelspruit", 9 },
                    { 3, "Graham's Town", 7 },
                    { 34, "Secunda", 9 },
                    { 7, "Virginia", 5 },
                    { 5, "Parys", 5 },
                    { 30, "Cape Town", 1 },
                    { 31, "Paarl", 1 },
                    { 32, "Simon's Town", 1 },
                    { 13, "Kimberly", 2 },
                    { 14, "Kuruman", 2 },
                    { 15, "Port Nolloth", 2 },
                    { 6, "Bloemfontein", 5 },
                    { 9, "Rustenberg", 3 },
                    { 11, "Klerksdorp", 3 },
                    { 12, "Mmabatho", 3 },
                    { 16, "Boksburg", 4 },
                    { 17, "Brakpan", 4 },
                    { 18, "Carletonville", 4 },
                    { 19, "Johannesburg", 4 },
                    { 10, "Mahikeng", 3 },
                    { 35, "Emulahleni", 9 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cities_ProvinceId",
                table: "Cities",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceItems_InvoiceId",
                table: "InvoiceItems",
                column: "InvoiceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adverts");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "InvoiceItems");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Provinces");

            migrationBuilder.DropTable(
                name: "Invoices");
        }
    }
}
