using Microsoft.EntityFrameworkCore;
using GameDnD.API.Models;

namespace GameDnD.API.Data
{
    public class GameContext : DbContext
    {
        public GameContext(DbContextOptions<GameContext> options) : base(options) { }

        public DbSet<Character> Characters { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Spell> Spells { get; set; }
    }
}
