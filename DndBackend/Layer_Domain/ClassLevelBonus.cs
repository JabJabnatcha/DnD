namespace Layer_Domain.Entities
{
    public class ClassLevelBonus
    {
        public int ClassLevelBonusId { get; private set; }

        public int ClassId { get; private set; }
        public int Level_class { get; private set; }
        public int Str_class { get; private set; }
        public int Agi_class { get; private set; }
        public int Int_class { get; private set; }
        public int Wis_class { get; private set; }
        public int Con_class { get; private set; }
        public int Cha_class { get; private set; }

        public Class Class { get; private set; } = null!;

        private ClassLevelBonus() { }

        public ClassLevelBonus(int classId, int level, string statName, int bonusValue)
{
    ClassId = classId;
    Level_class = level;

    switch (statName.ToLower())
    {
        case "str":
            Str_class = bonusValue;
            break;
        case "agi":
            Agi_class = bonusValue;
            break;
        case "int":
            Int_class = bonusValue;
            break;
        case "wis":
            Wis_class = bonusValue;
            break;
        case "con":
            Con_class = bonusValue;
            break;
        case "cha":
            Cha_class = bonusValue;
            break;
        default:
            throw new ArgumentException($"Unknown stat name: {statName}");
    }
}

    }
}
