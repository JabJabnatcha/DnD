using Microsoft.EntityFrameworkCore;
using Layer_Domain.Entities;

namespace Layer_Domain.Entities.Spells
{
    public class SpellCharacter
    {
        public int CharId { get; set; }
        public Character Character { get; set; } = null!;

        public int SpellId { get; set; }
        public Spell Spell { get; set; } = null!;
    }
}