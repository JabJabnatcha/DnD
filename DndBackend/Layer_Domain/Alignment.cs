namespace Layer_Domain.Entities
{
    public class Alignment
    {
        public int AlignmentId { get; private set; }
        public string Name { get; private set; } = null!;

        // สมมติว่า Alignment มี Characters ที่เกี่ยวข้องแบบ 1-to-many
        public ICollection<Character> Characters { get; private set; } = new List<Character>();

        private Alignment() { }

        public Alignment(string name)
        {
            Name = name;
        }
    }
}
