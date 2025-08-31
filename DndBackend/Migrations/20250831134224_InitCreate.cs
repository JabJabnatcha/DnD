using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DndBackend.Migrations
{
    /// <inheritdoc />
    public partial class InitCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    ClassId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrimaryAbility = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.ClassId);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemCategory = table.Column<int>(type: "int", nullable: false),
                    ArmorClass = table.Column<int>(type: "int", nullable: true),
                    MaxDexBonus = table.Column<int>(type: "int", nullable: true),
                    StealthDisadvantage = table.Column<bool>(type: "bit", nullable: true),
                    StrengthRequirement = table.Column<int>(type: "int", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    Effect = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SavingThrow = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Target = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DurationInRounds = table.Column<int>(type: "int", nullable: true),
                    Durability = table.Column<int>(type: "int", nullable: true),
                    IsEquipped = table.Column<bool>(type: "bit", nullable: true),
                    ToolType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecialFeature = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DamageDice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DamageType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Finesse = table.Column<bool>(type: "bit", nullable: true),
                    TwoHanded = table.Column<bool>(type: "bit", nullable: true),
                    Range = table.Column<int>(type: "int", nullable: true),
                    Properties = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ItemId);
                });

            migrationBuilder.CreateTable(
                name: "Races",
                columns: table => new
                {
                    RaceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RaceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RaceDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HeightMinCm = table.Column<int>(type: "int", nullable: false),
                    HeightMaxCm = table.Column<int>(type: "int", nullable: false),
                    WeightMinKg = table.Column<int>(type: "int", nullable: false),
                    WeightMaxKg = table.Column<int>(type: "int", nullable: false),
                    SpeedBase = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Races", x => x.RaceId);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Skill_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SkillName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ability = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Skill_Id);
                });

            migrationBuilder.CreateTable(
                name: "Spells",
                columns: table => new
                {
                    SpellId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpellName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpellDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    School = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CastingTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Range = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Components = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Target = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DamageType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DamageDice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsConcentration = table.Column<bool>(type: "bit", nullable: false),
                    RequiresSavingThrow = table.Column<bool>(type: "bit", nullable: false),
                    SavingThrowAbility = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Effect = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spells", x => x.SpellId);
                });

            migrationBuilder.CreateTable(
                name: "Subclasses",
                columns: table => new
                {
                    SubClassId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubClassName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubClassDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClassId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subclasses", x => x.SubClassId);
                    table.ForeignKey(
                        name: "FK_Subclasses_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "ClassId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Subraces",
                columns: table => new
                {
                    SubraceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubRaceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubRaceDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RaceId = table.Column<int>(type: "int", nullable: false),
                    StrBonus = table.Column<int>(type: "int", nullable: false),
                    DexBonus = table.Column<int>(type: "int", nullable: false),
                    ConBonus = table.Column<int>(type: "int", nullable: false),
                    IntBonus = table.Column<int>(type: "int", nullable: false),
                    WisBonus = table.Column<int>(type: "int", nullable: false),
                    ChaBonus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subraces", x => x.SubraceId);
                    table.ForeignKey(
                        name: "FK_Subraces_Races_RaceId",
                        column: x => x.RaceId,
                        principalTable: "Races",
                        principalColumn: "RaceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    CharId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CharName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Alignment = table.Column<int>(type: "int", nullable: false),
                    RaceId = table.Column<int>(type: "int", nullable: false),
                    SubraceId = table.Column<int>(type: "int", nullable: true),
                    ClassId = table.Column<int>(type: "int", nullable: false),
                    SubclassId = table.Column<int>(type: "int", nullable: true),
                    HeightCm = table.Column<int>(type: "int", nullable: false),
                    WeightKg = table.Column<int>(type: "int", nullable: false),
                    EyeColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HairColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SkinColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ScaleColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ScarOrMark = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExtraDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Biography = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Str = table.Column<int>(type: "int", nullable: false),
                    Dex = table.Column<int>(type: "int", nullable: false),
                    Con = table.Column<int>(type: "int", nullable: false),
                    Int = table.Column<int>(type: "int", nullable: false),
                    Wis = table.Column<int>(type: "int", nullable: false),
                    Cha = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.CharId);
                    table.ForeignKey(
                        name: "FK_Characters_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "ClassId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Characters_Races_RaceId",
                        column: x => x.RaceId,
                        principalTable: "Races",
                        principalColumn: "RaceId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Characters_Subclasses_SubclassId",
                        column: x => x.SubclassId,
                        principalTable: "Subclasses",
                        principalColumn: "SubClassId",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Characters_Subraces_SubraceId",
                        column: x => x.SubraceId,
                        principalTable: "Subraces",
                        principalColumn: "SubraceId",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Features",
                columns: table => new
                {
                    FeatureId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FeatureName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FeatureDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LevelRequired = table.Column<int>(type: "int", nullable: false),
                    RaceId = table.Column<int>(type: "int", nullable: true),
                    SubraceId = table.Column<int>(type: "int", nullable: true),
                    ClassId = table.Column<int>(type: "int", nullable: true),
                    SubclassId = table.Column<int>(type: "int", nullable: true),
                    ClassChatacterClassId = table.Column<int>(type: "int", nullable: true),
                    RaceCharacterRaceId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Features", x => x.FeatureId);
                    table.ForeignKey(
                        name: "FK_Features_Classes_ClassChatacterClassId",
                        column: x => x.ClassChatacterClassId,
                        principalTable: "Classes",
                        principalColumn: "ClassId");
                    table.ForeignKey(
                        name: "FK_Features_Races_RaceCharacterRaceId",
                        column: x => x.RaceCharacterRaceId,
                        principalTable: "Races",
                        principalColumn: "RaceId");
                    table.ForeignKey(
                        name: "FK_Features_Subclasses_SubclassId",
                        column: x => x.SubclassId,
                        principalTable: "Subclasses",
                        principalColumn: "SubClassId");
                    table.ForeignKey(
                        name: "FK_Features_Subraces_SubraceId",
                        column: x => x.SubraceId,
                        principalTable: "Subraces",
                        principalColumn: "SubraceId");
                });

            migrationBuilder.CreateTable(
                name: "CharacterItem",
                columns: table => new
                {
                    CharacterCharId = table.Column<int>(type: "int", nullable: false),
                    ItemsItemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterItem", x => new { x.CharacterCharId, x.ItemsItemId });
                    table.ForeignKey(
                        name: "FK_CharacterItem_Characters_CharacterCharId",
                        column: x => x.CharacterCharId,
                        principalTable: "Characters",
                        principalColumn: "CharId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterItem_Items_ItemsItemId",
                        column: x => x.ItemsItemId,
                        principalTable: "Items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateTable(
                name: "CharacterSpell",
                columns: table => new
                {
                    CharacterCharId = table.Column<int>(type: "int", nullable: false),
                    SpellsSpellId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterSpell", x => new { x.CharacterCharId, x.SpellsSpellId });
                    table.ForeignKey(
                        name: "FK_CharacterSpell_Characters_CharacterCharId",
                        column: x => x.CharacterCharId,
                        principalTable: "Characters",
                        principalColumn: "CharId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterSpell_Spells_SpellsSpellId",
                        column: x => x.SpellsSpellId,
                        principalTable: "Spells",
                        principalColumn: "SpellId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterFeature",
                columns: table => new
                {
                    CharacterCharId = table.Column<int>(type: "int", nullable: false),
                    FeaturesFeatureId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterFeature", x => new { x.CharacterCharId, x.FeaturesFeatureId });
                    table.ForeignKey(
                        name: "FK_CharacterFeature_Characters_CharacterCharId",
                        column: x => x.CharacterCharId,
                        principalTable: "Characters",
                        principalColumn: "CharId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterFeature_Features_FeaturesFeatureId",
                        column: x => x.FeaturesFeatureId,
                        principalTable: "Features",
                        principalColumn: "FeatureId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CharacterFeature_FeaturesFeatureId",
                table: "CharacterFeature",
                column: "FeaturesFeatureId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterItem_ItemsItemId",
                table: "CharacterItem",
                column: "ItemsItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_ClassId",
                table: "Characters",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_RaceId",
                table: "Characters",
                column: "RaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_SubclassId",
                table: "Characters",
                column: "SubclassId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_SubraceId",
                table: "Characters",
                column: "SubraceId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterSkill_SkillsSkill_Id",
                table: "CharacterSkill",
                column: "SkillsSkill_Id");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterSpell_SpellsSpellId",
                table: "CharacterSpell",
                column: "SpellsSpellId");

            migrationBuilder.CreateIndex(
                name: "IX_Features_ClassChatacterClassId",
                table: "Features",
                column: "ClassChatacterClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Features_RaceCharacterRaceId",
                table: "Features",
                column: "RaceCharacterRaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Features_SubclassId",
                table: "Features",
                column: "SubclassId");

            migrationBuilder.CreateIndex(
                name: "IX_Features_SubraceId",
                table: "Features",
                column: "SubraceId");

            migrationBuilder.CreateIndex(
                name: "IX_Subclasses_ClassId",
                table: "Subclasses",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Subraces_RaceId",
                table: "Subraces",
                column: "RaceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CharacterFeature");

            migrationBuilder.DropTable(
                name: "CharacterItem");

            migrationBuilder.DropTable(
                name: "CharacterSkill");

            migrationBuilder.DropTable(
                name: "CharacterSpell");

            migrationBuilder.DropTable(
                name: "Features");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "Spells");

            migrationBuilder.DropTable(
                name: "Subclasses");

            migrationBuilder.DropTable(
                name: "Subraces");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Races");
        }
    }
}
