namespace Layer_Domain.Entities
{
    public class Race
    {
        public int RaceId { get; set; }   // PK
        public string RaceName { get; set; } = null!;
        public decimal Speed { get; set; }
        public decimal MaxHeight { get; set; }
        public decimal MinHeight { get; set; }
        public decimal MaxWeight { get; set; }
        public decimal MinWeight { get; set; }

        // Navigation
        public ICollection<SubRace> SubRaces { get; set; } = new List<SubRace>();
        public ICollection<Traits> Traits { get; set; } = new List<Traits>();
    }
}
