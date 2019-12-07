using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AuctioinSite.Data.Migrations
{
    public partial class ListingViewModelsController : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ListingViewModel",
                columns: table => new
                {
                    listingId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    listingName = table.Column<string>(nullable: true),
                    listItemCondition = table.Column<string>(nullable: true),
                    isShipping = table.Column<bool>(nullable: false),
                    listingBuyOutPrice = table.Column<int>(nullable: false),
                    lisingStartingPrice = table.Column<int>(nullable: false),
                    listingPostDate = table.Column<DateTime>(nullable: false),
                    listingEndDate = table.Column<DateTime>(nullable: false),
                    listingDescription = table.Column<string>(nullable: true),
                    listingCategory = table.Column<string>(nullable: true),
                    listingImageURL = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListingViewModel", x => x.listingId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ListingViewModel");
        }
    }
}
