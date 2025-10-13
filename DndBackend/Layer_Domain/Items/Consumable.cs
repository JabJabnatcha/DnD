namespace Layer_Domain.Entities.Items
{
    public class Consumable : ITEM
{
    public int Quantity { get; set; }
    public string? Effect { get; set; }       // e.g., Heal 2d4+2
    public string? SavingThrow { get; set; }  // e.g., Dex
    public string? Target { get; set; }       // e.g., "One creature"
    public int DurationInRounds { get; set; } // ถ้ามี duration
}

}
