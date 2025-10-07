using System.ComponentModel.DataAnnotations;
using Layer_Domain.Entities.Race;

namespace Layer_Domain.Entities
{
    public class RACE_FEATURE
    {
        [Key]
        public int RaceFeatureId { get; set; }

        public int RaceId { get; set; }
        public required CHARACTER_RACE Race { get; set; }

        public int FeatureId { get; set; }
        public required FEATURE Feature { get; set; }
    }
}
