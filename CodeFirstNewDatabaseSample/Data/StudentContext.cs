using Microsoft.EntityFrameworkCore;

namespace CodeFirstNewDatabaseSample
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(
                "Server=(localdb)\\MSSQLLocalDB;Database=StudentDatabase;Trusted_Connection=True;");
        }
    }
}
