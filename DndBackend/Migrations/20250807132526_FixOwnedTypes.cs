using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DndBackend.Migrations
{
    /// <inheritdoc />
    public partial class FixOwnedTypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StatusBases");

            migrationBuilder.DropTable(
                name: "StatusBonus");

            migrationBuilder.AddColumn<int>(
                name: "StatusBase_Agi",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StatusBase_Cha",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StatusBase_Con",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StatusBase_Int",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StatusBase_StatusBaseId",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StatusBase_Str",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StatusBase_Wis",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StatusBonus_AgiBonus",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StatusBonus_ChaBonus",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StatusBonus_ConBonus",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StatusBonus_IntBonus",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StatusBonus_StrBonus",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StatusBonus_WisBonus",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StatusBase_Agi",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "StatusBase_Cha",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "StatusBase_Con",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "StatusBase_Int",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "StatusBase_StatusBaseId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "StatusBase_Str",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "StatusBase_Wis",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "StatusBonus_AgiBonus",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "StatusBonus_ChaBonus",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "StatusBonus_ConBonus",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "StatusBonus_IntBonus",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "StatusBonus_StrBonus",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "StatusBonus_WisBonus",
                table: "Characters");

            migrationBuilder.CreateTable(
                name: "StatusBases",
                columns: table => new
                {
                    StatusBaseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CharacterId = table.Column<int>(type: "int", nullable: false),
                    Agi = table.Column<int>(type: "int", nullable: false),
                    Cha = table.Column<int>(type: "int", nullable: false),
                    Con = table.Column<int>(type: "int", nullable: false),
                    Int = table.Column<int>(type: "int", nullable: false),
                    Str = table.Column<int>(type: "int", nullable: false),
                    Wis = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusBases", x => x.StatusBaseId);
                    table.ForeignKey(
                        name: "FK_StatusBases_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "CharacterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StatusBonus",
                columns: table => new
                {
                    StatusBonusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CharacterId = table.Column<int>(type: "int", nullable: false),
                    AgiBonus = table.Column<int>(type: "int", nullable: false),
                    BonusStatusId = table.Column<int>(type: "int", nullable: false),
                    ChaBonus = table.Column<int>(type: "int", nullable: false),
                    ConBonus = table.Column<int>(type: "int", nullable: false),
                    IntBonus = table.Column<int>(type: "int", nullable: false),
                    StrBonus = table.Column<int>(type: "int", nullable: false),
                    WisBonus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusBonus", x => x.StatusBonusId);
                    table.ForeignKey(
                        name: "FK_StatusBonus_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "CharacterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StatusBases_CharacterId",
                table: "StatusBases",
                column: "CharacterId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StatusBonus_CharacterId",
                table: "StatusBonus",
                column: "CharacterId",
                unique: true);
        }
    }
}
