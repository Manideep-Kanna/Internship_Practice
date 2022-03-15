using Microsoft.EntityFrameworkCore;
namespace Student
{
    internal class Databasecontext : DbContext
    {
        public DbSet<StudentClass> students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog= StudentMS; Integrated Security= true");
            }
            base.OnConfiguring(optionsBuilder);

        }
    }
}
