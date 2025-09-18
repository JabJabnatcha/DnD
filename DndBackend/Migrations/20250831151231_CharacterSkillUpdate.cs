using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DndBackend.Migrations
{
    /// <inheritdoc />
    public partial class CharacterSkillUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CharacterSkill");

            migrationBuilder.DropColumn(
                name: "Ability",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "SkillName",
                table: "Skills");

            migrationBuilder.RenameColumn(
                name: "Skill_Id",
                table: "Skills",
                newName: "SkillId");

            migrationBuilder.AddColumn<int>(
                name: "Acrobatics",
                table: "Skills",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "AcrobaticsProficient",
                table: "Skills",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "AnimalHandling",
                table: "Skills",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "AnimalHandlingProficient",
                table: "Skills",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Arcana",
                table: "Skills",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "ArcanaProficient",
                table: "Skills",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Athletics",
                table: "Skills",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "AthleticsProficient",
                table: "Skills",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "CharId",
                table: "Skills",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Deception",
                table: "Skills",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "DeceptionProficient",
                table: "Skills",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "History",
                table: "Skills",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "HistoryProficient",
                table: "Skills",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Insight",
                table: "Skills",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "InsightProficient",
                table: "Skills",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Intimidation",
                table: "Skills",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IntimidationProficient",
                table: "Skills",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Investigation",
                table: "Skills",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "InvestigationProficient",
                table: "Skills",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Medicine",
                table: "Skills",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "MedicineProficient",
                table: "Skills",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Nature",
                table: "Skills",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "NatureProficient",
                table: "Skills",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Perception",
                table: "Skills",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "PerceptionProficient",
                table: "Skills",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Performance",
                table: "Skills",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "PerformanceProficient",
                table: "Skills",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Persuasion",
                table: "Skills",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "PersuasionProficient",
                table: "Skills",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Religion",
                table: "Skills",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "ReligionProficient",
                table: "Skills",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SleightOfHand",
                table: "Skills",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "SleightOfHandProficient",
                table: "Skills",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Stealth",
                table: "Skills",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "StealthProficient",
                table: "Skills",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Survival",
                table: "Skills",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "SurvivalProficient",
                table: "Skills",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_Skills_CharId",
                table: "Skills",
                column: "CharId");

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_Characters_CharId",
                table: "Skills",
                column: "CharId",
                principalTable: "Characters",
                principalColumn: "CharId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Skills_Characters_CharId",
                table: "Skills");

            migrationBuilder.DropIndex(
                name: "IX_Skills_CharId",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "Acrobatics",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "AcrobaticsProficient",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "AnimalHandling",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "AnimalHandlingProficient",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "Arcana",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "ArcanaProficient",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "Athletics",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "AthleticsProficient",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "CharId",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "Deception",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "DeceptionProficient",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "History",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "HistoryProficient",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "Insight",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "InsightProficient",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "Intimidation",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "IntimidationProficient",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "Investigation",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "InvestigationProficient",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "Medicine",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "MedicineProficient",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "Nature",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "NatureProficient",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "Perception",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "PerceptionProficient",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "Performance",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "PerformanceProficient",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "Persuasion",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "PersuasionProficient",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "Religion",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "ReligionProficient",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "SleightOfHand",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "SleightOfHandProficient",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "Stealth",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "StealthProficient",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "Survival",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "SurvivalProficient",
                table: "Skills");

            migrationBuilder.RenameColumn(
                name: "SkillId",
                table: "Skills",
                newName: "Skill_Id");

            migrationBuilder.AddColumn<string>(
                name: "Ability",
                table: "Skills",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SkillName",
                table: "Skills",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "CharacterSkill",
                columns: table => new
                {
                    CharacterCharId = table.Column<int>(type: "int", nullable: false),
                    SkillsSkill_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterSkill", x => new { x.CharacterCharId, x.SkillsSkill_Id });
                    table.ForeignKey(
                        name: "FK_CharacterSkill_Characters_CharacterCharId",
                        column: x => x.CharacterCharId,
                        principalTable: "Characters",
                        principalColumn: "CharId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterSkill_Skills_SkillsSkill_Id",
                        column: x => x.SkillsSkill_Id,
                        principalTable: "Skills",
                        principalColumn: "Skill_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CharacterSkill_SkillsSkill_Id",
                table: "CharacterSkill",
                column: "SkillsSkill_Id");
        }
    }
}
