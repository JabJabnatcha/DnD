using Microsoft.EntityFrameworkCore;
using Layer_Domain.Entities.Race;
using Layer_Domain.Entities.Class;
using Layer_Domain.Entities.Items;
using Layer_Domain.Entities.Spells;
using System.ComponentModel.DataAnnotations;

namespace Layer_Domain.Entities
{
    public class CHARACTER
    {
        [Key]
        public int CharId { get; set; }
        public required string PlayerName { get; set; }
        public required string CharName { get; set; }
        public ALIGNMENT Alignment { get; set; }
        public int Level { get; set; }
        public int ExperiencePoints { get; set; }

        // Race/Subrace
        public int RaceId { get; set; }
        public CHARACTER_RACE Race { get; set; } = null!;   // Navigation property
        public int? SubraceId { get; set; }
        public SUB_RACE Subrace { get; set; } = null!;

        // Class/Subclass
        public int ClassId { get; set; }
        public CHARACTER_CLASS Class { get; set; } = null!; // Navigation property
        public int? SubclassId { get; set; }
        public SUB_CHARACTER_CLASS? Subclass { get; set; }

        // Appearance
        public int HeightCm { get; set; }
        public int WeightKg { get; set; }
        public required string EyeColor { get; set; }
        public required string HairColor { get; set; }
        public required string SkinColor { get; set; }
        public string ScaleColor { get; set; } = string.Empty;// สำหรับ Dragonborn หรือสัตว์ประหลาด
        public string ScarOrMark { get; set; } = string.Empty;
        public string ExtraDescription { get; set; } = string.Empty;
        public string Biography { get; set; } = string.Empty;

        public int Base_Str { get; set; }
        public int Bonus_Str { get; set; }
        public int Base_Dex { get; set; }
        public int Bonus_Dex { get; set; }
        public int Base_Con { get; set; }
        public int Bonus_Con { get; set; }
        public int Base_Int { get; set; }
        public int Bonus_Int { get; set; }
        public int Base_Wis { get; set; }
        public int Bonus_Wis { get; set; }
        public int Base_Cha { get; set; }
        public int Bonus_Cha { get; set; }

        public int Inspiration { get; set; }
        public int ProficiencyBonus { get; set; }
        public int ArmorClass { get; set; }
        public int Initiative { get; set; }
        public int Speed { get; set; }
        public int MaxHitPoints { get; set; }
        public int CurrentHitPoints { get; set; }
        public int TemporaryHitPoints { get; set; }

        public int DeathSaveSuccess { get; set; }
        public int DeathSaveFailure { get; set; }

        public int PassivePerception { get; set; }

        // Navigation properties
        public int Acrobatics { get; set; }
        public bool AcrobaticsProficient { get; set; }

        public int AnimalHandling { get; set; }
        public bool AnimalHandlingProficient { get; set; }

        public int Arcana { get; set; }
        public bool ArcanaProficient { get; set; }

        public int Athletics { get; set; }
        public bool AthleticsProficient { get; set; }

        public int Deception { get; set; }
        public bool DeceptionProficient { get; set; }

        public int History { get; set; }
        public bool HistoryProficient { get; set; }

        public int Insight { get; set; }
        public bool InsightProficient { get; set; }

        public int Intimidation { get; set; }
        public bool IntimidationProficient { get; set; }

        public int Investigation { get; set; }
        public bool InvestigationProficient { get; set; }

        public int Medicine { get; set; }
        public bool MedicineProficient { get; set; }

        public int Nature { get; set; }
        public bool NatureProficient { get; set; }

        public int Perception { get; set; }
        public bool PerceptionProficient { get; set; }

        public int Performance { get; set; }
        public bool PerformanceProficient { get; set; }

        public int Persuasion { get; set; }
        public bool PersuasionProficient { get; set; }

        public int Religion { get; set; }
        public bool ReligionProficient { get; set; }

        public int SleightOfHand { get; set; }
        public bool SleightOfHandProficient { get; set; }

        public int Stealth { get; set; }
        public bool StealthProficient { get; set; }

        public int Survival { get; set; }
        public bool SurvivalProficient { get; set; }

        public INVENTORY Inventories { get; set; } = new();
        public Bank? Bank { get; set; }

        // // Junction tables
        // public List<SpellCharacter> SpellsCharacter { get; set; } = new();

        public bool IsDeleted { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        
    }
}
