namespace Layer_Domain.Entities.Items
{
    public class Equipment : ITEM
    {
        public int Durability { get; set; }
        public bool IsEquipped { get; set; }
    }
}
