using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BushcraftBlog.Server.Migrations
{
    /// <inheritdoc />
    public partial class UPDATE_Data_Topic_Tag : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Topic",
                newName: "TopicId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Tag",
                newName: "TagId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TopicId",
                table: "Topic",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "TagId",
                table: "Tag",
                newName: "Id");
        }
    }
}
