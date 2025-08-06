namespace Layer_Domain.Entities
{
    public class Character
    {
        public int CharacterId { get; private set; }
        public string charracter_name { get; private set; } = null!;
        public int Level { get; private set; }

        public int RaceId { get; private set; }
        public Race Race { get; private set; } = null!;

        public int ClassId { get; private set; }
        public Class Class { get; private set; } = null!;

        public int AlignmentId { get; private set; }
        public Alignment Alignment { get; private set; } = null!;

        public StatusBase StatusBase { get; private set; } = null!;
        public StatusBonus StatusBonus { get; private set; } = null!;
    }
}
