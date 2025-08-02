namespace Layer_Domain.Entities
{
    public class StatusBonus
    {
        public int BonusStatusId { get; private set; }
        public int CharacterId { get; private set; }

        public string SourceType { get; private set; } = null!; // equipment, buff, debuff, etc.
        public string SourceId { get; private set; } = null!;

        public int StrBonus { get; private set; }
        public int AgiBonus { get; private set; }
        public int IntBonus { get; private set; }
        public int WisBonus { get; private set; }
        public int ConBonus { get; private set; }
        public int ChaBonus { get; private set; }

        public Character Character { get; private set; } = null!;

        private StatusBonus() { }

        public StatusBonus(int characterId, string sourceType, string sourceId,
            int strBonus, int agiBonus, int intBonus, int wisBonus, int conBonus, int chaBonus)
        {
            CharacterId = characterId;
            SourceType = sourceType;
            SourceId = sourceId;
            StrBonus = strBonus;
            AgiBonus = agiBonus;
            IntBonus = intBonus;
            WisBonus = wisBonus;
            ConBonus = conBonus;
            ChaBonus = chaBonus;
        }
    }
}
