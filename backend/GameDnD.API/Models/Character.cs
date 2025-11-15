namespace GameDnD.API.Models
{
    public class Character
    {
        public int Id { get; set; }

        // Basic profile
        public string Name { get; set; } = string.Empty;
        public string Race { get; set; } = string.Empty;     // Human, Elf, Dwarf etc.
        public string Class { get; set; } = string.Empty;    // Fighter, Wizard, Rogue

        // Progression
        public int Level { get; set; } = 1;
        public int Experience { get; set; } = 0;

        // Ability Scores (D&D 6 ค่าหลัก)
        public int Strength { get; set; } = 0;
        public int Dexterity { get; set; } = 0;
        public int Constitution { get; set; } = 0;
        public int Intelligence { get; set; } = 0;
        public int Wisdom { get; set; } = 0;
        public int Charisma { get; set; } = 0;

        // Derived Stats
        public int MaxHP { get; set; } = 0;
        public int CurrentHP { get; set; } = 0;
        public int MaxMP { get; set; } = 0;
        public int CurrentMP { get; set; } = 0;

        public int ArmorClass { get; set; } = 0;
        public int Initiative { get; set; } = 0;
        public int Speed { get; set; } = 30;  // 30 feet default

        // Inventory (ใน version 1 อาจเป็น list id)
        public List<Item> Items { get; set; } = new();

        // Known Spells
        public List<Spell> Spells { get; set; } = new();

        // Soft delete
        public bool IsDeleted { get; set; } = false;
    }
}
