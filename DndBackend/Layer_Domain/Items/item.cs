using System.ComponentModel.DataAnnotations;

namespace Layer_Domain.Entities.Items
{
    public abstract class Item
    {
        [Key]
        public int ItemId { get; set; }
        public required string ItemName { get; set; }
        public required string ItemDescription { get; set; }
        public ItemCategory ItemCategory { get; set; } // Weapon, Armor, Consumable, Tool, Other
    }
    public enum ItemCategory
    {
        Weapon,
        Armor,
        Consumable,
        Tool,
        Other
    }
}