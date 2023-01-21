using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NewsWebsiteExercise.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                    table.ForeignKey(
                        name: "FK_News_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Pets" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Wildlife" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Culinary" });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "CategoryId", "Description", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Local wolf lady Sejt was found this morning doing the amogus twerk at park, gathering a large crowd of observers.", "Sejt has the moves!" },
                    { 2, 1, "According to local cat expert Riche Shinta \"Cats are the most trustworthy animals of all time, and they definitely deserve a bit of salami every now and then, as a treat.\"", "Cats, should you trust them?" },
                    { 3, 1, "He's a good boy. That's it, that's the whole article, everything past riodoche migration will just have placeholder Lorem Ipsum text.", "Why you should forfeit all mortal posessions to Seth" },
                    { 4, 2, "Early this Monday, the local Riodoche population has begun their yearly migration up the mountain stream, where thousands of Famiries will form Staccs and Triamgles while vibin' in the tall grass.", "Riodoche migration going smoothly." },
                    { 5, 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque imperdiet auctor erat, id varius ipsum. Phasellus eget augue vestibulum, rutrum turpis eu, tempor mauris. Etiam commodo ligula sit amet mauris scelerisque efficitur. Aenean sit amet lobortis lacus, vitae placerat erat. Aliquam erat volutpat. Etiam luctus, massa ac bibendum eleifend, odio elit mollis purus, et blandit dui nulla quis ex. Nunc quis luctus velit. Pellentesque varius sollicitudin magna, nec fermentum felis vehicula sed. Sed cursus magna vitae augue feugiat, a ultrices enim varius. Proin tempus felis ut pulvinar viverra. Nulla vestibulum nibh in mauris imperdiet varius. Fusce imperdiet viverra libero id malesuada. Morbi pellentesque cursus efficitur. Sed fermentum sagittis mauris. Nulla laoreet ligula ut varius tempor.", "Tribal rabbits? Everything you need to know!" },
                    { 6, 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque imperdiet auctor erat, id varius ipsum. Phasellus eget augue vestibulum, rutrum turpis eu, tempor mauris. Etiam commodo ligula sit amet mauris scelerisque efficitur. Aenean sit amet lobortis lacus, vitae placerat erat. Aliquam erat volutpat. Etiam luctus, massa ac bibendum eleifend, odio elit mollis purus, et blandit dui nulla quis ex. Nunc quis luctus velit. Pellentesque varius sollicitudin magna, nec fermentum felis vehicula sed. Sed cursus magna vitae augue feugiat, a ultrices enim varius. Proin tempus felis ut pulvinar viverra. Nulla vestibulum nibh in mauris imperdiet varius. Fusce imperdiet viverra libero id malesuada. Morbi pellentesque cursus efficitur. Sed fermentum sagittis mauris. Nulla laoreet ligula ut varius tempor.", "Woman falls in love with giant monkey." },
                    { 7, 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque imperdiet auctor erat, id varius ipsum. Phasellus eget augue vestibulum, rutrum turpis eu, tempor mauris. Etiam commodo ligula sit amet mauris scelerisque efficitur. Aenean sit amet lobortis lacus, vitae placerat erat. Aliquam erat volutpat. Etiam luctus, massa ac bibendum eleifend, odio elit mollis purus, et blandit dui nulla quis ex. Nunc quis luctus velit. Pellentesque varius sollicitudin magna, nec fermentum felis vehicula sed. Sed cursus magna vitae augue feugiat, a ultrices enim varius. Proin tempus felis ut pulvinar viverra. Nulla vestibulum nibh in mauris imperdiet varius. Fusce imperdiet viverra libero id malesuada. Morbi pellentesque cursus efficitur. Sed fermentum sagittis mauris. Nulla laoreet ligula ut varius tempor.", "Bug lady reveals secret to her family restaurant's delicious stews" },
                    { 8, 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque imperdiet auctor erat, id varius ipsum. Phasellus eget augue vestibulum, rutrum turpis eu, tempor mauris. Etiam commodo ligula sit amet mauris scelerisque efficitur. Aenean sit amet lobortis lacus, vitae placerat erat. Aliquam erat volutpat. Etiam luctus, massa ac bibendum eleifend, odio elit mollis purus, et blandit dui nulla quis ex. Nunc quis luctus velit. Pellentesque varius sollicitudin magna, nec fermentum felis vehicula sed. Sed cursus magna vitae augue feugiat, a ultrices enim varius. Proin tempus felis ut pulvinar viverra. Nulla vestibulum nibh in mauris imperdiet varius. Fusce imperdiet viverra libero id malesuada. Morbi pellentesque cursus efficitur. Sed fermentum sagittis mauris. Nulla laoreet ligula ut varius tempor.", "Hyper realistic fitness cake shocks party goers" },
                    { 9, 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque imperdiet auctor erat, id varius ipsum. Phasellus eget augue vestibulum, rutrum turpis eu, tempor mauris. Etiam commodo ligula sit amet mauris scelerisque efficitur. Aenean sit amet lobortis lacus, vitae placerat erat. Aliquam erat volutpat. Etiam luctus, massa ac bibendum eleifend, odio elit mollis purus, et blandit dui nulla quis ex. Nunc quis luctus velit. Pellentesque varius sollicitudin magna, nec fermentum felis vehicula sed. Sed cursus magna vitae augue feugiat, a ultrices enim varius. Proin tempus felis ut pulvinar viverra. Nulla vestibulum nibh in mauris imperdiet varius. Fusce imperdiet viverra libero id malesuada. Morbi pellentesque cursus efficitur. Sed fermentum sagittis mauris. Nulla laoreet ligula ut varius tempor.", "Bugsnax and how to avoid them" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_News_CategoryId",
                table: "News",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
