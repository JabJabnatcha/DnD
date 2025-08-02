namespace Layer_Domain.Entities
{
    public class Race
    {
        public int RaceId { get; private set; }
        public string RaceName { get; private set; } = null!;

        public int StrBonus { get; private set; }
        public int AgiBonus { get; private set; }
        public int WisBonus { get; private set; }
        public int ConBonus { get; private set; }
        public int IntBonus { get; private set; }
        public int ChaBonus { get; private set; }

        public ICollection<Character> Characters { get; private set; } = new List<Character>();

        private Race() { }

        public Race(string raceName, int strBonus, int agiBonus, int wisBonus, int conBonus, int intBonus, int chaBonus)
        {
            RaceName = raceName;
            StrBonus = strBonus;
            AgiBonus = agiBonus;
            WisBonus = wisBonus;
            ConBonus = conBonus;
            IntBonus = intBonus;
            ChaBonus = chaBonus;
        }
    }
}
