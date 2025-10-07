using System.ComponentModel.DataAnnotations;
using Layer_Domain.Entities.Race;
using Layer_Domain.Entities.Class;

namespace Layer_Domain.Entities
{
    public class FEATURE
    {
        [Key]
        public int FeatureId { get; set; }
        public required string FeatureName { get; set; }
        public required string FeatureDescription { get; set; }
        public int LevelRequired { get; set; } = 1;

        // Navigation (M:N)
        public List<RACE_FEATURE> RaceFeatures { get; set; } = new();
        public List<SUB_RACE_FEATURE> SubraceFeatures { get; set; } = new();
        public List<CLASS_FEATURE> ClassFeatures { get; set; } = new();
        public List<SUB_CLASS_FEATURE> SubclassFeatures { get; set; } = new();
    }
}
