using Microsoft.EntityFrameworkCore;
using Layer_Domain.Entities.Class;


namespace Layer_Domain.Entities.Spells
{
    public class SpellClass
    {
        public int ClassId { get; set; }
        public ClassChatacter Class { get; set; } = null!;

        public int SpellId { get; set; }
        public Spell Spell { get; set; } = null!;
    }
}
