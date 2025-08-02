namespace Layer_Domain.Entities
{
    public class ClassLevelBonus
    {
        public int ClassLevelBonusId { get; private set; }

        public int ClassId { get; private set; }
        public int Level { get; private set; }
        public string StatName { get; private set; } = null!;
        public int BonusValue { get; private set; }

        public Class Class { get; private set; } = null!;

        private ClassLevelBonus() { }

        public ClassLevelBonus(int classId, int level, string statName, int bonusValue)
        {
            ClassId = classId;
            Level = level;
            StatName = statName;
            BonusValue = bonusValue;
        }
    }
}
