using System.ComponentModel.DataAnnotations;
using Layer_Domain.Entities.Spells;
using Microsoft.EntityFrameworkCore;

namespace Layer_Domain.Entities.Class
{
    public class ClassChatacter
    {
        [Key]
        public int ClassId { get; set; } //pk
        public required string ClassName { get; set; }
        public required string ClassDescription { get; set; }
        public required string PrimaryAbility { get; set; }
        public List<Feature> Features { get; set; } = new();
        public List<Subclass> Subclasses { get; set; } = new();
        public List<SpellClass> SpellsClass { get; set; } = new();
    }
}
