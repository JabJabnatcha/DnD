namespace Layer_Domain.Entities
{
    public class Class
    {
        public int ClassId { get; private set; }
        public string ClassName { get; private set; } = null!;

        public ICollection<Character> Characters { get; private set; } = new List<Character>();
        public ICollection<ClassLevelBonus> ClassLevelBonuses { get; private set; } = new List<ClassLevelBonus>();

        private Class() { }

        public Class(string className)
        {
            ClassName = className;
        }
    }
}
