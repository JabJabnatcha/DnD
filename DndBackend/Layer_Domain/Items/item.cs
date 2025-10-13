using System.ComponentModel.DataAnnotations;

namespace Layer_Domain.Entities.Items
{
    public abstract class ITEM
    {
        [Key]
        public int ItemId { get; set; }
        public required string ItemName { get; set; }
        public required string ItemDescription { get; set; }

        public List<INVENTORY> Inventories { get; set; } = new();
        public List<BankItem> BankItems { get; set; } = new();
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