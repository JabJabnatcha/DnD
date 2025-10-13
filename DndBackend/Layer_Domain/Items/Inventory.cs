using System.ComponentModel.DataAnnotations;

namespace Layer_Domain.Entities.Items
{
    public class INVENTORY
    {
        [Key]
        public int InventoryId { get; set; }

        public int CharId { get; set; }
        public CHARACTER Character { get; set; } = null!;

        public int Currency_CP { get; set; }
        public int Currency_SP { get; set; }
        public int Currency_EP { get; set; }
        public int Currency_GP { get; set; }
        public int Currency_PP { get; set; }
        public List<InventoryItem> InventoryItems { get; set; } = new();
        public bool IsEquipped { get; set; } = false;
        public enum EquipmentSlot
        {
            Weapon1,
            Weapon2,
            Armor,
            Accessory,
            Shield
        }
    }
    public class InventoryItem
    {
        public int InventoryItemId { get; set; }
        public int InventoryId { get; set; }
        public INVENTORY? Inventory { get; set; }
        public int ItemId { get; set; }
        public ITEM? ITEM { get; set; }
        public int Quantity { get; set; }
        public bool IsEquipped { get; set; }
        public string Slot { get; set; } = string.Empty;
    }


}