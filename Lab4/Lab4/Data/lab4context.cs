using Lab4.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Lab4.Data
{
    public class lab4context : DbContext
    {
        private object optionsBuilder;

        public DbSet<Student> Students { get; set; }
        public DbSet<Curs> Cursuri { get; set; }

        public lab4context(DbContextOptions<lab4context> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
            .HasKey(s => s.Id);

            modelBuilder.Entity<Student>()
            .HasMany(s => s.Cursuri)
            .WithOne(c => c.Student)
            .HasForeignKey(c => c.StudentId);

        }

    }
}
