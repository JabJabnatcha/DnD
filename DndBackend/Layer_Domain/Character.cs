namespace Layer_Domain.Entities
{
    public class Character
    {
        public int CharacterId { get; private set; }
        public string charracter_name { get; private set; } = null!;
        public int Level { get; private set; }

        public int RaceId { get; private set; }
        public Race Race { get; private set; } = null!;

        public int ClassId { get; private set; }
        public Class Class { get; private set; } = null!;

        public int AlignmentId { get; private set; }
        public Alignment Alignment { get; private set; } = null!;

        public StatusBase StatusBase { get; private set; } = null!;
        public StatusBonus StatusBonus { get; private set; } = null!;

        // ✅ Constructor ที่ให้ StatusBonus มี default value เป็น new StatusBonus()
        public Character(
            string characterName,
            int level,
            int raceId,
            int classId,
            int alignmentId,
            StatusBase statusBase,
            StatusBonus? statusBonus = null) // ทำให้รับ null ได้
        {
            charracter_name = characterName;
            Level = level;
            RaceId = raceId;
            ClassId = classId;
            AlignmentId = alignmentId;
            StatusBase = statusBase;

            // ✅ ถ้าไม่ส่ง statusBonus มา จะใช้ค่าดีฟอลต์
            StatusBonus = statusBonus ?? new StatusBonus();
        }
        public Character() { }

    }
}
