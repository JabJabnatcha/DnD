namespace Layer_Domain.Entities
{
    public class StatusBonus
    {
        public int StrBonus { get; private set; }
        public int AgiBonus { get; private set; }
        public int IntBonus { get; private set; }
        public int WisBonus { get; private set; }
        public int ConBonus { get; private set; }
        public int ChaBonus { get; private set; }

        // ✅ Constructor พร้อมค่า default = 0
        public StatusBonus(
            int strBonus = 0,
            int agiBonus = 0,
            int intBonus = 0,
            int wisBonus = 0,
            int conBonus = 0,
            int chaBonus = 0)
        {
            StrBonus = strBonus;
            AgiBonus = agiBonus;
            IntBonus = intBonus;
            WisBonus = wisBonus;
            ConBonus = conBonus;
            ChaBonus = chaBonus;
        }
    }
}
