
using Layer_Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DndBackend.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alignments",
                columns: table => new
                {
                    AlignmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alignments", x => x.AlignmentId);
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    ClassId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.ClassId);
                });

            migrationBuilder.CreateTable(
                name: "Races",
                columns: table => new
                {
                    RaceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RaceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Str_race = table.Column<int>(type: "int", nullable: false),
                    Agi_race = table.Column<int>(type: "int", nullable: false),
                    Wis_race = table.Column<int>(type: "int", nullable: false),
                    Con_race = table.Column<int>(type: "int", nullable: false),
                    Int_race = table.Column<int>(type: "int", nullable: false),
                    Cha_race = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Races", x => x.RaceId);
                });

            migrationBuilder.CreateTable(
                name: "ClassLevelBonus",
                columns: table => new
                {
                    ClassLevelBonusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassId = table.Column<int>(type: "int", nullable: false),
                    Level_class = table.Column<int>(type: "int", nullable: false),
                    Str_class = table.Column<int>(type: "int", nullable: false),
                    Agi_class = table.Column<int>(type: "int", nullable: false),
                    Int_class = table.Column<int>(type: "int", nullable: false),
                    Wis_class = table.Column<int>(type: "int", nullable: false),
                    Con_class = table.Column<int>(type: "int", nullable: false),
                    Cha_class = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassLevelBonus", x => x.ClassLevelBonusId);
                    table.ForeignKey(
                        name: "FK_ClassLevelBonus_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "ClassId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    CharacterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    charracter_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    RaceId = table.Column<int>(type: "int", nullable: false),
                    ClassId = table.Column<int>(type: "int", nullable: false),
                    AlignmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.CharacterId);
                    table.ForeignKey(
                        name: "FK_Characters_Alignments_AlignmentId",
                        column: x => x.AlignmentId,
                        principalTable: "Alignments",
                        principalColumn: "AlignmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Characters_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "ClassId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Characters_Races_RaceId",
                        column: x => x.RaceId,
                        principalTable: "Races",
                        principalColumn: "RaceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StatusBases",
                columns: table => new
                {
                    StatusBaseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CharacterId = table.Column<int>(type: "int", nullable: false),
                    Str = table.Column<int>(type: "int", nullable: false),
                    Agi = table.Column<int>(type: "int", nullable: false),
                    Int = table.Column<int>(type: "int", nullable: false),
                    Wis = table.Column<int>(type: "int", nullable: false),
                    Con = table.Column<int>(type: "int", nullable: false),
                    Cha = table.Column<int>(type: "int", nullable: false)
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
                    BonusStatusId = table.Column<int>(type: "int", nullable: false),
                    CharacterId = table.Column<int>(type: "int", nullable: false),
                    SourceType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SourceId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StrBonus = table.Column<int>(type: "int", nullable: false),
                    AgiBonus = table.Column<int>(type: "int", nullable: false),
                    IntBonus = table.Column<int>(type: "int", nullable: false),
                    WisBonus = table.Column<int>(type: "int", nullable: false),
                    ConBonus = table.Column<int>(type: "int", nullable: false),
                    ChaBonus = table.Column<int>(type: "int", nullable: false)
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
                name: "IX_Characters_AlignmentId",
                table: "Characters",
                column: "AlignmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_ClassId",
                table: "Characters",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_RaceId",
                table: "Characters",
                column: "RaceId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassLevelBonus_ClassId",
                table: "ClassLevelBonus",
                column: "ClassId");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClassLevelBonus");

            migrationBuilder.DropTable(
                name: "StatusBases");

            migrationBuilder.DropTable(
                name: "StatusBonus");

            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "Alignments");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Races");
        }
    }
}
