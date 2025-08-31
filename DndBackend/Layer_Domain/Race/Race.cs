using System.ComponentModel.DataAnnotations;

namespace Layer_Domain.Entities.Race
{
    public class RaceCharacter
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
        public List<Subrace> Subraces { get; set; } = new();
        public List<Feature> Features { get; set; } = new();
    }
}
