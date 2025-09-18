using Microsoft.EntityFrameworkCore;
using Layer_Domain.Entities.Race;
using Layer_Domain.Entities.Class;
using Layer_Domain.Entities.Items; 
using Layer_Domain.Entities.Spells;
using System.ComponentModel.DataAnnotations;

namespace Layer_Domain.Entities
{
    public class Feature
    {
        [Key]
        public int FeatureId { get; set; }
        public required string FeatureName { get; set; }
        public required string FeatureDescription { get; set; }
        public int LevelRequired { get; set; } = 1;

        public int? RaceId { get; set; }
        public int? SubraceId { get; set; }
        public int? ClassId { get; set; }
        public int? SubclassId { get; set; }
    }
}
