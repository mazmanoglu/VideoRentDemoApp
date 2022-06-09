using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VideoRentDemoApp.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Renters",
                columns: table => new
                {
                    RenterId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 30, nullable: false),
                    LastName = table.Column<string>(maxLength: 30, nullable: false),
                    RentedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Renters", x => x.RenterId);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    MovieId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    Length = table.Column<int>(nullable: false),
                    DateRelease = table.Column<DateTime>(nullable: false),
                    Genre = table.Column<string>(nullable: true),
                    MainActress = table.Column<string>(maxLength: 50, nullable: true),
                    ImdbUrl = table.Column<string>(nullable: true),
                    RenterId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.MovieId);
                    table.ForeignKey(
                        name: "FK_Movies_Renters_RenterId",
                        column: x => x.RenterId,
                        principalTable: "Renters",
                        principalColumn: "RenterId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "DateRelease", "Description", "Genre", "ImageUrl", "ImdbUrl", "Length", "MainActress", "RenterId", "Title" },
                values: new object[] { 4, new DateTime(1986, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "As students at the United States Navy's elite fighter weapons school compete to be best in the class, one daring young pilot learns a few things from a civilian instructor that are not taught in the classroom.", "Action-Drama", "topgun.jpg", "https://www.imdb.com/title/tt0092099/", 110, "Kelly McGills", null, "Top Gun" });

            migrationBuilder.InsertData(
                table: "Renters",
                columns: new[] { "RenterId", "FirstName", "LastName", "RentedDate" },
                values: new object[,]
                {
                    { 1, "Fatih", "Ozer", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Anass", "Allamzi", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Olga", "Kharchuk", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "DateRelease", "Description", "Genre", "ImageUrl", "ImdbUrl", "Length", "MainActress", "RenterId", "Title" },
                values: new object[] { 1, new DateTime(1997, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "A seventeen-year-old aristocrat falls in love with a kind but poor artist aboard the luxurious, ill-fated R.M.S. Titanic", "Romance", "Titanic.jpg", "https://www.imdb.com/title/tt0120338/", 125, "Kate Winslet", 1, "Titanic" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "DateRelease", "Description", "Genre", "ImageUrl", "ImdbUrl", "Length", "MainActress", "RenterId", "Title" },
                values: new object[] { 2, new DateTime(2009, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "In Nazi-occupied France during World War II, a plan to assasinate Nazi leaders by a group of Jewish U.S. soldiers coincides with a theatre owner's vengeful plans for the same", "Action", "InBasterds.jpg", "https://www.imdb.com/title/tt0361748/", 105, "Diane Kruger", 2, "Inglorious Basterds" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "DateRelease", "Description", "Genre", "ImageUrl", "ImdbUrl", "Length", "MainActress", "RenterId", "Title" },
                values: new object[] { 3, new DateTime(2013, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "After the crew of the Enterprise find an unstoppable force of terror from within their own organization, Captain Kirk leads a manhunt to a war-zone world to capture a one-man weapon of mass destruction", "Sci-Fi", "StarTrek.jpg", "https://www.imdb.com/title/tt1408101/", 135, "Zoe Saldana", 2, "Star Trek - Into Darkness" });

            migrationBuilder.CreateIndex(
                name: "IX_Movies_RenterId",
                table: "Movies",
                column: "RenterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Renters");
        }
    }
}
