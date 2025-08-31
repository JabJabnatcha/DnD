using Layer_Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Layer_Infrastructure.Data
{
    public class DndDbContextFactory : IDesignTimeDbContextFactory<DndDbContext>
    {
        public DndDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DndDbContext>();
            // ใส่ connection string ที่คุณใช้จริง
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=DndDb;Trusted_Connection=True;");

            return new DndDbContext(optionsBuilder.Options);
        }
    }
}
