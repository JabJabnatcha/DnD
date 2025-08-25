using Microsoft.EntityFrameworkCore;
using Layer_Domain.Entities;

namespace Layer_Infrastructure
{
    public class DndDbDbContext : DbContext
    {
        // กำหนด DbSet สำหรับแต่ละ Entity
        public DbSet<Character> Characters { get; set; } = null!;
        public DbSet<Race> Races { get; set; } = null!;
        public DbSet<SubRace> SubRaces { get; set; } = null!;
        public DbSet<Traits> Traits { get; set; } = null!;
        public DbSet<Class> Classes { get; set; } = null!;
        public DbSet<Alignment> Alignments { get; set; } = null!;

        // กำหนดการเชื่อมต่อ DB
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // ✅ เปลี่ยน connection string ตาม DB ของคุณ
                optionsBuilder.UseSqlServer("Server=localhost;Database=RPG_DB;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // สามารถใส่ Fluent API กำหนดความสัมพันธ์พิเศษที่ EF Core เดาไม่ได้
        }
    }
}
