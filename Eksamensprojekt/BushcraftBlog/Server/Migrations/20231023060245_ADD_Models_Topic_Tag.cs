using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BushcraftBlog.Server.Migrations
{
    /// <inheritdoc />
    public partial class ADD_Models_Topic_Tag : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tag",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tag", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tag_Documents_DocumentId",
                        column: x => x.DocumentId,
                        principalTable: "Documents",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Topic",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topic", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Topic_Documents_DocumentId",
                        column: x => x.DocumentId,
                        principalTable: "Documents",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tag_DocumentId",
                table: "Tag",
                column: "DocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_Topic_DocumentId",
                table: "Topic",
                column: "DocumentId");

            #region Add rows of topics to table
            migrationBuilder.InsertData(table: "Topic", new string[] { "Name", "Description" }, new string[] { "Cutting Tools", "Documents focusing on Cutting Tools." });
            migrationBuilder.InsertData(table: "Topic", new string[] { "Name", "Description" }, new string[] { "Shelter", "Documents focusing on building shelters." });
            migrationBuilder.InsertData(table: "Topic", new string[] {"Name", "Description"}, new string[] {"Core Temperature", "Documents focusing on balancing Core Temperature." });
            #endregion

            #region Add rows of tags to table
            migrationBuilder.InsertData(table: "Tag", new string[] {"Name", "Description"}, new string[] {"5CS", "The 5 Cs of Survivability."} );
            migrationBuilder.InsertData(table: "Tag", new string[] {"Name", "Description"}, new string[] {"10CS", "The 10 Cs of Survivability."} );
            migrationBuilder.InsertData(table: "Tag", new string[] {"Name", "Description"}, new string[] { "Cutting Tool", "Cutting Tool for processing material in nature."} );
            migrationBuilder.InsertData(table: "Tag", new string[] {"Name", "Description"}, new string[] { "Combustion Device", "Combustion Device to start a fire to keep you warm and prepare food."} );
            migrationBuilder.InsertData(table: "Tag", new string[] {"Name", "Description"}, new string[] { "Container", "Container for cooking food and carrying ressources ie. water."} );
            migrationBuilder.InsertData(table: "Tag", new string[] {"Name", "Description"}, new string[] { "Cordage", "Cordage for helping in building a shelter."} );
            migrationBuilder.InsertData(table: "Tag", new string[] {"Name", "Description"}, new string[] { "Cover", "Shelter for protecting you against the elements of nature."} );
            #endregion
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tag");

            migrationBuilder.DropTable(
                name: "Topic");
        }
    }
}
