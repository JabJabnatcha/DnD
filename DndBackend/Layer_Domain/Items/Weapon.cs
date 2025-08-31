namespace Layer_Domain.Entities.Items
{
    public class Weapon : Item
    {
        public required string DamageDice { get; set; }    // e.g., "1d8"
        public required string DamageType { get; set; }    // e.g., "Slashing", "Piercing"
        public bool Finesse { get; set; }
        public bool TwoHanded { get; set; }
        public int Range { get; set; }            // สำหรับ ranged weapons
        public List<string> Properties { get; set; } = new(); // e.g., "Light", "Thrown"
    }
}