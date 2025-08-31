namespace Layer_Domain.Entities.Spells
{
    public class Spell
    {
        public int SpellId { get; set; }
        
        public required string SpellName { get; set; }
        public required string SpellDescription { get; set; }
        public int Level { get; set; }
        public required string School { get; set; } // Evocation, Necromancy, etc.

        // Casting properties
        public required string CastingTime { get; set; }  // e.g., "1 action", "1 bonus action"
        public required string Range { get; set; }        // e.g., "60 feet", "Self"
        public required string Duration { get; set; }     // e.g., "Instantaneous", "1 hour"
        public required string Components { get; set; }   // e.g., "V, S, M"

        // Targeting & Damage
        public string? Target { get; set; }              // e.g., "One creature", "All enemies in area"
        public string? DamageType { get; set; }          // e.g., "Fire", "Necrotic"
        public string? DamageDice { get; set; }          // e.g., "2d6", "1d8"

        // Additional optional properties
        public bool IsConcentration { get; set; } = false;
        public bool RequiresSavingThrow { get; set; } = false;
        public string? SavingThrowAbility { get; set; } // e.g., "Dex", "Wis"
        public string? Effect { get; set; }             // e.g., "Stunned", "Knocked prone"
    }
}
