using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BushcraftBlog.Server.Migrations
{
    /// <inheritdoc />
    public partial class INIT : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    DocumentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Heading = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TopicStrings = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TagStrings = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.DocumentId);
                });

            migrationBuilder.CreateTable(
                name: "Tag",
                columns: table => new
                {
                    TagId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tag", x => x.TagId);
                });

            migrationBuilder.CreateTable(
                name: "Topic",
                columns: table => new
                {
                    TopicId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topic", x => x.TopicId);
                });

            migrationBuilder.InsertData(
                table: "Documents",
                columns: new[] { "DocumentId", "Content", "Heading", "Name", "TagStrings", "TopicStrings" },
                values: new object[,]
                {
                    { 1, "Carry at least one Cutting Tool. Preferably more than one!", "Cutting Tools - be sure to carry one", "First Document on Cutting Tools", "Cutting Tool", "Cutting Tools,Saws,Axes" },
                    { 2, "A Shelter gives you a place to rest shielded against the elements of nature.", "Shelters - shield yourself against the elements", "First Document on Shelters", "Combustion Device,Cover,Core Temperature", "Shelter,Core Temperature" },
                    { 3, "It´s important to keep an eye on Core Temperature when out in nature.", "Core Temperature - always stay warm", "First Document on Core Temperature", "Cover,Core Temperature", "Shelter,Core Temperature" }
                });

            migrationBuilder.InsertData(
                table: "Tag",
                columns: new[] { "TagId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "The 5 Cs of Survivability.", "5CS" },
                    { 2, "The 10 Cs of Survivability.", "10CS" },
                    { 3, "Cutting Tool for processing material in nature.", "Cutting Tool" },
                    { 4, "Combustion Device to start a fire to keep you warm and prepare food.", "Combustion Device" },
                    { 5, "Container for cooking food and carrying ressources ie. water.", "Container" },
                    { 6, "Cordage for helping in building a shelter.", "Cordage" },
                    { 7, "Shelter for protecting you against the elements of nature.", "Cover" },
                    { 8, "Core Temperature is important to keep an eye on.", "Core Temperature" }
                });

            migrationBuilder.InsertData(
                table: "Topic",
                columns: new[] { "TopicId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Cutting Tools as a topic in general.", "Cutting Tools" },
                    { 2, "Shelters as a topic.", "Shelter" },
                    { 3, "Core Temperature as a topic.", "Core Temperature" },
                    { 4, "Saws as a topic", "Saws" },
                    { 5, "Axes as a topic", "Axes" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropTable(
                name: "Tag");

            migrationBuilder.DropTable(
                name: "Topic");
        }
    }
}
