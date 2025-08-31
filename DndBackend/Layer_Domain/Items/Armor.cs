namespace Layer_Domain.Entities.Items
{
    public class Armor : Item
    {
        public int ArmorClass { get; set; }
        public int MaxDexBonus { get; set; }      // Max dex modifier
        public bool StealthDisadvantage { get; set; }
        public int StrengthRequirement { get; set; } // ถ้า Heavy armor
    }
} 