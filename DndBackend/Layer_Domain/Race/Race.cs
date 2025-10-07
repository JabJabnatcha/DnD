using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Layer_Domain.Entities.Race
{
    public class CHARACTER_RACE
    {
        [Key]
        public int RaceId { get; set; } //pk
        public required string RaceName { get; set; }
        public required string RaceDescription { get; set; }

        public int HeightMinCm { get; set; }
        public int HeightMaxCm { get; set; }
        public int WeightMinKg { get; set; }
        public int WeightMaxKg { get; set; }
        public int SpeedBase { get; set; }

        // Navigation
        public List<SUB_RACE> SUBRACEs { get; set; } = new();
        public List<SUB_RACE_FEATURE> SUBRACEFEATUREs { get; set; } = new();
    }
}
