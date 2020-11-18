using Microsoft.EntityFrameworkCore.Migrations;

namespace FullStack.Data.Migrations
{
    public partial class Update1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "publishedDate",
                table: "Adverts",
                newName: "PublishedDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn( 
                name: "PublishedDate",
                table: "Adverts",
                newName: "publishedDate");
        }
    }
}
