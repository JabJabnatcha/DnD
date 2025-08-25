namespace Layer_Domain.Entities
{
    public class SubRace
    {
        public int SubRaceId { get; set; }   // PK

        public int RaceId { get; set; }
        public Race Race { get; set; } = null!;

        // Navigation
        public ICollection<Traits> Traits { get; set; } = new List<Traits>();
    }
}
