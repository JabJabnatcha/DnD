namespace Layer_Domain.Entities
{
    public class Traits
    {
        public int TraitsId { get; set; }   // PK

        public int RaceId { get; set; }
        public Race Race { get; set; } = null!;

        public int SubRaceId { get; set; }
        public SubRace SubRace { get; set; } = null!;

        public int Darkvision { get; set; } = 0;
        public int KeenSenses { get; set; } = 1;
    }
}
