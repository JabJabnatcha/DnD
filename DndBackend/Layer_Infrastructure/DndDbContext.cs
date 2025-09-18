using Layer_Domain.Entities;
using Layer_Domain.Entities.Class;
using Layer_Domain.Entities.Race;
using Layer_Domain.Entities.Items;
using Layer_Domain.Entities.Spells;
using Microsoft.EntityFrameworkCore;

namespace Layer_Infrastructure.Data
{
    public class DndDbContext : DbContext
    {
        public DndDbContext(DbContextOptions<DndDbContext> options) : base(options) { }

        public DbSet<Character> Characters { get; set; }
        public DbSet<RaceCharacter> Races { get; set; }
        public DbSet<Subrace> Subraces { get; set; }
        public DbSet<ClassChatacter> Classes { get; set; }
        public DbSet<Subclass> Subclasses { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Spell> Spells { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Skill> Skills { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // TPH สำหรับ Item inheritance
            modelBuilder.Entity<Item>()
                        .HasDiscriminator(i => i.ItemCategory)
                        .HasValue<Weapon>(ItemCategory.Weapon)
                        .HasValue<Armor>(ItemCategory.Armor)
                        .HasValue<Consumable>(ItemCategory.Consumable)
                        .HasValue<Tool>(ItemCategory.Tool)
                        .HasValue<Equipment>(ItemCategory.Other);

            // Character -> Race/Subrace
            modelBuilder.Entity<Character>()
                .HasOne(c => c.Race)
                .WithMany()
                .HasForeignKey(c => c.RaceId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Character>()
                .HasOne(c => c.Subrace)
                .WithMany()
                .HasForeignKey(c => c.SubraceId)
                .OnDelete(DeleteBehavior.SetNull);

            // Character -> Class/Subclass
            modelBuilder.Entity<Character>()
                .HasOne(c => c.Class)
                .WithMany()
                .HasForeignKey(c => c.ClassId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Character>()
                .HasOne(c => c.Subclass)
                .WithMany()
                .HasForeignKey(c => c.SubclassId)
                .OnDelete(DeleteBehavior.SetNull);

            // Character -> Items
            modelBuilder.Entity<Character>()
                .HasMany(c => c.Items)
                .WithMany();

            // Character -> Spells
            modelBuilder.Entity<Character>()
                .HasMany(c => c.SpellsCharacter)
                .WithMany();

            // Class <-> Spell
            modelBuilder.Entity<SpellClass>()
                .HasKey(cs => new { cs.ClassId, cs.SpellId });

            modelBuilder.Entity<SpellClass>()
                .HasOne(cs => cs.Class)
                .WithMany(c => c.SpellsClass)
                .HasForeignKey(cs => cs.ClassId);

            modelBuilder.Entity<SpellClass>()
                .HasOne(cs => cs.Spell)
                .WithMany(s => s.SpellsClass)
                .HasForeignKey(cs => cs.SpellId);

            // Character <-> Spell
            modelBuilder.Entity<SpellCharacter>()
                .HasKey(cs => new { cs.CharId, cs.SpellId });

            modelBuilder.Entity<SpellCharacter>()
                .HasOne(cs => cs.Character)
                .WithMany(c => c.SpellsCharacter)
                .HasForeignKey(cs => cs.CharId);

            modelBuilder.Entity<SpellCharacter>()
                .HasOne(cs => cs.Spell)
                .WithMany(s => s.SpellsCharacter)
                .HasForeignKey(cs => cs.SpellId);

            // Character -> Features
            modelBuilder.Entity<Character>()
                .HasMany(c => c.Features)
                .WithMany();

            // Character -> Skills (One-to-Many)
            modelBuilder.Entity<Character>()
            .HasMany(c => c.Skills)
            .WithOne(s => s.Character)
            .HasForeignKey(s => s.CharId)
            .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
