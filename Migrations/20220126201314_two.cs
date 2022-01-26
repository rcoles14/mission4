using Microsoft.EntityFrameworkCore.Migrations;

namespace mission4.Migrations
{
    public partial class two : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "responses",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(nullable: false),
                    Category = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: true),
                    LentTo = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_responses", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "id", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, "Comedy/Crime", "The Coen Brothers", false, null, null, "R", "The Big Lebowski", 1998 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "id", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, "Crime/Drama/Thriller", "Todd Phillips", false, null, null, "R", "Joker", 2019 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "id", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, "Action/Thriller", "Christopher Nolan", false, null, null, "PG-13", "Tenet", 2020 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "responses");
        }
    }
}
