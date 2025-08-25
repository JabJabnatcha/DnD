namespace Layer_Domain.Entities
{
    public class Alignment
    {
        public int AlignmentId { get; set; }   // PK, Auto Increment
        public string AlignmentName { get; set; } = null!;

        // Navigation
        public ICollection<Character> Characters { get; set; } = new List<Character>();
    }
}
