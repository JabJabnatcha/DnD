using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Layer_Domain.Entities.Class
{
    public class SUB_CHARACTER_CLASS
    {
        [Key]
        public int SubClassId { get; set; }
        public required string SubClassName { get; set; }
        public required string SubClassDescription { get; set; }

        public int ClassId { get; set; }
        public required CHARACTER_CLASS CharacterClasses { get; set; }

        public List<SUB_CLASS_FEATURE> SUBCLASSFEATUREs { get; set; } = new();
    }
}
