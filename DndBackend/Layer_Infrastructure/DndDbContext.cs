
using Microsoft.EntityFrameworkCore;  
using Layer_Domain.Entities;
//C:\Users\Laptop-JAB\Desktop\Learn\DnD\DndBackend\Layer_Infrastructure\DndDbContext.cs
namespace Layer_Infrastructure{
    public class DndDbContext : DbContext
    {
        public DndDbContext(DbContextOptions<DndDbContext> options)
            : base(options) { }

        public DbSet<Character> Characters { get; set; }
        public DbSet<Race> Races { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Alignment> Alignments { get; set; }
        public DbSet<ClassLevelBonus> ClassLevelBonus { get; set; }
        // ลบออก 2 ตัวนี้
        // public DbSet<StatusBase> StatusBases { get; set; }
        // public DbSet<StatusBonus> StatusBonus { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Character>(entity =>
            {
                // กำหนด StatusBase เป็น Owned Type
                entity.OwnsOne(c => c.StatusBase);

                // กำหนด StatusBonus เป็น Owned Type
                entity.OwnsOne(c => c.StatusBonus);
            });
        }
    }
}