using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DndBackend.Migrations
{
    /// <inheritdoc />
    public partial class RemoveSourceFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SourceId",
                table: "StatusBonus");

            migrationBuilder.DropColumn(
                name: "SourceType",
                table: "StatusBonus");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SourceId",
                table: "StatusBonus",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SourceType",
                table: "StatusBonus",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
