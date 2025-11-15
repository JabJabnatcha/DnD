namespace GameDnD.API.Models
{
    public class Spell
    {
        public int Id { get; set; }

        public int CharacterId { get; set; }
        public Character Character { get; set; } = null!;

        public string Name { get; set; } = string.Empty;
        public int Level { get; set; } = 1;
        public string School { get; set; } = string.Empty; // Evocation, Illusion etc.
    }
}
