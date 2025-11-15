namespace GameDnD.API.Models
{
    public class Item
    {
        public int Id { get; set; }

        public int CharacterId { get; set; }  
        public Character Character { get; set; } = null!;

        public string Name { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;  // Weapon, Armor, Consumable etc.
        public string Rarity { get; set; } = "Common";
    }
}
