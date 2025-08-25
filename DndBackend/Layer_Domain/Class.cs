namespace Layer_Domain.Entities
{
    public class Class
    {
        public int ClassId { get; set; }   // PK
        public string ClassName { get; set; } = null!;
        public string PrimaryAbility { get; set; } = null!;
        public string HpDice { get; set; } = null!;
        public string SavingThrow { get; set; } = null!;
        public string WeaponProficiencies { get; set; } = null!;
        public string ArmorTraining { get; set; } = null!;
        public string SpacialTool { get; set; } = null!;

        // Navigation
        public ICollection<Character> Characters { get; set; } = new List<Character>();
    }
}
