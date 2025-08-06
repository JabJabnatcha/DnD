using Microsoft.EntityFrameworkCore;
using Layer_Domain.Entities;

namespace DndBackend.Data
{
    public class DndDbContext : DbContext
    {
        public DndDbContext(DbContextOptions<DndDbContext> options)
            : base(options) { }

        public DbSet<Character> Characters { get; set; }
        public DbSet<Race> Races { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Alignment> Alignments { get; set; }
        public DbSet<ClassLevelBonus> ClassLevelBonus { get; set; }
        public DbSet<StatusBase> StatusBases { get; set; }
        public DbSet<StatusBonus> StatusBonus { get; set; }
    }
}
