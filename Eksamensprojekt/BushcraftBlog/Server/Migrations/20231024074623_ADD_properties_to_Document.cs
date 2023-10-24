using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BushcraftBlog.Server.Migrations
{
    /// <inheritdoc />
    public partial class ADD_properties_to_Document : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DocumentImage",
                table: "Documents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExternalSourcesStrings",
                table: "Documents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 1,
                columns: new[] { "DocumentImage", "ExternalSourcesStrings" },
                values: new object[] { "KnifeAxeBowsaw.jpg", "https://www.youtube.com/watch?v=5UeIgzd8oto,https://www.youtube.com/watch?v=uK7l2JsI61c,https://www.youtube.com/watch?v=eoRODhOMcUk" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 2,
                columns: new[] { "DocumentImage", "ExternalSourcesStrings" },
                values: new object[] { "BushcraftShelter.jpg", "https://www.youtube.com/watch?v=-_ve7ExM29Y,https://www.youtube.com/watch?v=ZV92xni5q8w,https://www.youtube.com/watch?v=MITdT_we1WE" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 3,
                columns: new[] { "Content", "DocumentImage", "ExternalSourcesStrings", "Heading" },
                values: new object[] { "It´s important to keep an eye on Core Temperature when out in nature. If you get too cold in the winter season you risk getting pneumonia and if you get too hot in the summer time you risk getting dehydrated.", "Ilustration_V2_A_stylistic_logo_of_a_bonfire_where_an_open_boo_2,jpg", "https://www.youtube.com/watch?v=7KojHvHCrjE,https://www.youtube.com/watch?v=ysw6CEbSiak,https://www.youtube.com/watch?v=B_vqXkCe-r4", "Core Temperature - keep it within comfortable limits" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DocumentImage",
                table: "Documents");

            migrationBuilder.DropColumn(
                name: "ExternalSourcesStrings",
                table: "Documents");

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 3,
                columns: new[] { "Content", "Heading" },
                values: new object[] { "It´s important to keep an eye on Core Temperature when out in nature.", "Core Temperature - always stay warm" });
        }
    }
}
