namespace Layer_Domain.Entities.Items
{
    public class Tool : ITEM
    {
        public string ToolType { get; set; } = string.Empty;   // Rope, ThievesTools, MusicalInstrument, Artisan
        public string? SpecialFeature { get; set; }            // e.g., Advantage on checks
    }
}
