using System.ComponentModel.DataAnnotations;
using Layer_Domain.Entities.Class;
using Layer_Domain.Entities.Race;

namespace Layer_Domain.Entities
{
    public class SUB_CLASS_FEATURE
    {
        [Key]
        public int ClassFeatureId { get; set; }

        public int ClassId { get; set; }
        public required CHARACTER_CLASS Class { get; set; }

        public int FeatureId { get; set; }
        public required FEATURE Feature { get; set; }
    }
}
