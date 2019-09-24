using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gardenalogue.Core.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gardens",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gardens", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Gardens",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "rights" },
                    { 24, "Post-ironic" },
                    { 23, "direct" },
                    { 22, "Post-ironic" },
                    { 21, "truck" },
                    { 20, "tofu" },
                    { 19, "rights" },
                    { 18, "way" },
                    { 17, "apparel" },
                    { 16, "irony" },
                    { 15, "butcher" },
                    { 14, "terry" },
                    { 13, "work" },
                    { 12, "VHS" },
                    { 11, "cray" },
                    { 10, "richardson" },
                    { 9, "gastropub" },
                    { 8, "fanny" },
                    { 7, "mixtape" },
                    { 6, "Post-ironic" },
                    { 5, "direct" },
                    { 4, "beer" },
                    { 3, "direct" },
                    { 2, "pork" },
                    { 25, "number" },
                    { 26, "viral" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Gardens");
        }
    }
}
