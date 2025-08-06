namespace Layer_Domain.Entities
{
    public class Race
    {
        public int RaceId { get; private set; }
        public string RaceName { get; private set; } = null!;

        public int Str_race { get; private set; }
        public int Agi_race { get; private set; }
        public int Wis_race { get; private set; }
        public int Con_race { get; private set; }
        public int Int_race { get; private set; }
        public int Cha_race { get; private set; }

        public ICollection<Character> Characters { get; private set; } = new List<Character>();

        private Race() { }

        public Race(string raceName, int str_race, int agi_race, int wis_race, int con_race, int int_race, int cha_race)
        {
            RaceName = raceName;
            Str_race = str_race;
            Agi_race = agi_race;
            Wis_race = wis_race;
            Con_race = con_race;
            Int_race = int_race;
            Cha_race = cha_race;
        }
    }
}
