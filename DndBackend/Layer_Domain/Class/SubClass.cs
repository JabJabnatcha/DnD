using System.ComponentModel.DataAnnotations;

namespace Layer_Domain.Entities.Class
{
    public class Subclass
    {
        [Key]
        public int SubClassId { get; set; }
        public required string SubClassName { get; set; }
        public required string SubClassDescription { get; set; }

        public int ClassId { get; set; }
        public required ClassChatacter Class { get; set; }

        public List<Feature> Features { get; set; } = new();
    }
}
