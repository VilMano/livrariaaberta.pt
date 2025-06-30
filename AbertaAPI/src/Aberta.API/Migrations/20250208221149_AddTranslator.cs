using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AbertaAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddTranslator : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Translator",
                table: "Books",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Translator",
                table: "Books");
        }
    }
}
