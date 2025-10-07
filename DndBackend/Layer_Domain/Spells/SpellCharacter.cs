using Microsoft.EntityFrameworkCore;
using Layer_Domain.Entities;

namespace Layer_Domain.Entities.Spells
{
    public class SPELL_CHARACTER
    {
        public int CharId { get; set; }
        public CHARACTER Character { get; set; } = null!;

        public int SpellId { get; set; }
        public SPELL Spell { get; set; } = null!;
    }
}