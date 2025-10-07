using System.ComponentModel.DataAnnotations;
using Layer_Domain.Entities.Race;

namespace Layer_Domain.Entities
{
    public class SUB_RACE_FEATURE
    {
        [Key]
        public int SubraceFeatureId { get; set; }

        public int SubraceId { get; set; }
        public required SUB_RACE Subrace { get; set; }

        public int FeatureId { get; set; }
        public required FEATURE Feature { get; set; }
    }
}
