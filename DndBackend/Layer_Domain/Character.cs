namespace Layer_Domain.Entities
{
    public class Character
    {
        public int CharacterId { get; set; }   // PK
        public string CharacterName { get; set; } = null!;
        public string PlayerName { get; set; } = null!;
        public int Level { get; set; } = 1;
        public decimal Exp { get; set; } = 0;

        // FK
        public int RaceId { get; set; }
        public Race Race { get; set; } = null!;

        public int ClassId { get; set; }
        public Class CharacterClass { get; set; } = null!;

        public int AlignmentId { get; set; }
        public Alignment Alignment { get; set; } = null!;
    }
}
