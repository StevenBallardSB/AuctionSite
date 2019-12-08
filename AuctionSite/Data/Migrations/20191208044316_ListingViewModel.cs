using Microsoft.EntityFrameworkCore.Migrations;

namespace AuctioinSite.Data.Migrations
{
    public partial class ListingViewModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "listingAuthor",
                table: "ListingViewModel",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "listingAuthor",
                table: "ListingViewModel");
        }
    }
}
