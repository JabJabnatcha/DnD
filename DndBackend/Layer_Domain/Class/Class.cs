using System.ComponentModel.DataAnnotations;
using Layer_Domain.Entities.Spells;
using Microsoft.EntityFrameworkCore;

namespace Layer_Domain.Entities.Class
{
    public class CHARACTER_CLASS
    {
        [Key]
        public int ClassId { get; set; } //pk
        public required string ClassName { get; set; }
        public required string ClassDescription { get; set; }
        public required string PrimaryAbility { get; set; }
        public List<CLASS_FEATURE> CLASSFEATUREs { get; set; } = new();
        public List<SUB_CHARACTER_CLASS> SUBCHARACTERCLASSes { get; set; } = new();
        // public List<SpellClass> SpellsClass { get; set; } = new();
    }
}
