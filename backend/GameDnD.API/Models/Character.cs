namespace GameDnD.API.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Class { get; set; } = string.Empty;
        public int Level { get; set; } = 1;
        public int HP { get; set; } = 10;
        public int MP { get; set; } = 5;
        public bool IsDeleted { get; set; } = false; // soft delete
    }
}
