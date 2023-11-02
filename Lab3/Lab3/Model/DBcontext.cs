using Microsoft.EntityFrameworkCore;

namespace Lab3.Model
{
    public class DBcontext : DbContext
    {
        public DbSet<Student> students { get; set; }

        public DBcontext(DbContextOptions options) : base(options) { }
    }
}
