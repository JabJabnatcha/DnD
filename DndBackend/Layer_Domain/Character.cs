using Microsoft.EntityFrameworkCore;
using Layer_Domain.Entities;
using Layer_Domain.Entities.Race;
using Layer_Domain.Entities.Class;
using Layer_Domain.Entities.Items; 
using Layer_Domain.Entities.Spells;
using System.ComponentModel.DataAnnotations;

namespace Layer_Domain.Entities
{
    public class Character
    {
        [Key]
        public int CharId { get; set; }
        public required string PlayerName { get; set; }
        public required string CharName { get; set; }
        public required string Surname { get; set; }
        public Alignment Alignment { get; set; }

        // Race/Subrace
        public int RaceId { get; set; }
        public RaceCharacter Race { get; set; } = null!;   // Navigation property
        public int? SubraceId { get; set; }
        public Subrace? Subrace { get; set; }

        // Class/Subclass
        public int ClassId { get; set; }
        public ClassChatacter Class { get; set; } = null!; // Navigation property
        public int? SubclassId { get; set; }
        public Subclass? Subclass { get; set; }

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

        // Stats
        public int Str { get; set; }
        public int Dex { get; set; }
        public int Con { get; set; }
        public int Int { get; set; }
        public int Wis { get; set; }
        public int Cha { get; set; }

        // Navigation
        public List<Feature> Features { get; set; } = new();
        public List<Skill> Skills { get; set; } = new();
        public List<Item> Items { get; set; } = new();
        public List<Spell> Spells { get; set; } = new();
    }
}
