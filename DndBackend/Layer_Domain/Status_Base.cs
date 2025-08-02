namespace Layer_Domain.Entities
{
    public class StatusBase
    {
        public int StatusBaseId { get; private set; }
        public int CharacterId { get; private set; }

        public int Str { get; private set; }
        public int Agi { get; private set; }
        public int Int { get; private set; }
        public int Wis { get; private set; }
        public int Con { get; private set; }
        public int Cha { get; private set; }

        public Character Character { get; private set; } = null!;
    }
}