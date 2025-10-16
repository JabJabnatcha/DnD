using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Layer_Domain.Entities.Items
{
    /// <summary>
    /// INVENTORY: แทนคลังของ character หนึ่งคน
    /// 1 character จะมี inventory เพียงหนึ่ง
    /// เก็บข้อมูล currency ทั้งหมดของ character ไว้ที่นี่
    /// รายการ item จะอยู่ใน InventoryItems (junction table)
    /// </summary>
    public class INVENTORY
    {
        [Key]
        public int InventoryId { get; set; }

        // Character owner
        public int CharId { get; set; }
        public CHARACTER Character { get; set; } = null!;

        // Currency ของ character
        public int Currency_CP { get; set; } = 0;
        public int Currency_SP { get; set; } = 0;
        public int Currency_EP { get; set; } = 0;
        public int Currency_GP { get; set; } = 0;
        public int Currency_PP { get; set; } = 0;

        // รายการ item ทั้งหมดของ inventory
        public List<InventoryItem> InventoryItems { get; set; } = new();

        // ไม่จำเป็นต้องมี IsEquipped / Slot ที่นี่
        // เพราะข้อมูลเหล่านี้อยู่ที่ InventoryItem (item แต่ละชิ้น)
    }

    /// <summary>
    /// InventoryItem: junction table ระหว่าง Inventory กับ Item
    /// ใช้เก็บ item แต่ละชิ้น, จำนวน, slot และสถานะ equipped
    /// </summary>
    public class InventoryItem
    {
        [Key]
        public int InventoryItemId { get; set; }

        // Relation กลับไปยัง inventory
        public int InventoryId { get; set; }
        public INVENTORY? Inventory { get; set; }

        // Relation กับ item
        public int ItemId { get; set; }
        public ITEM? Item { get; set; }

        // จำนวน item
        public int Quantity { get; set; } = 0;

        // อุปกรณ์นี้ถูก equip หรือไม่
        public bool IsEquipped { get; set; } = false;

        // Slot ของ item เช่น Weapon1, Armor เป็นต้น
        // ใช้ enum แทน string เพื่อลด typo และ validate ง่าย
        public EquipmentSlot Slot { get; set; } = EquipmentSlot.Weapon1;
    }

    /// <summary>
    /// EquipmentSlot: enum สำหรับระบุ slot ของ item
    /// </summary>
    public enum EquipmentSlot
    {
        Weapon1,
        Weapon2,
        Armor,
        Accessory1,
        Accessory2,
        Other
    }
}
