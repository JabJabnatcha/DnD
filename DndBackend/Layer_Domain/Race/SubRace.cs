using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Layer_Domain.Entities.Race
{
    public class Subrace
    {
        [Key]
        public int SubraceId { get; set; }
        public required string SubRaceName { get; set; }
        public required string SubRaceDescription { get; set; }

        public int RaceId { get; set; }
        public required RaceCharacter Race { get; set; }

        // Stat bonus
        public int StrBonus { get; set; }
        public int DexBonus { get; set; }
        public int ConBonus { get; set; }
        public int IntBonus { get; set; }
        public int WisBonus { get; set; }
        public int ChaBonus { get; set; }

        // Navigation
        public List<Feature> Features { get; set; } = new();
    }
}
