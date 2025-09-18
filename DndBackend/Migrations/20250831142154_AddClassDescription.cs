using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DndBackend.Migrations
{
    /// <inheritdoc />
    public partial class AddClassDescription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ClassDescription",
                table: "Classes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClassDescription",
                table: "Classes");
        }
    }
}
