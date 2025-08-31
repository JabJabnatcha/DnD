using System.ComponentModel.DataAnnotations;

namespace Layer_Domain.Entities
{
    public class Skill
    {
        [Key]
        public int Skill_Id { get; set; }
        public required string SkillName { get; set; }
        public required string Ability { get; set; } // STR/DEX/CON/INT/WIS/CHA
    }
}
