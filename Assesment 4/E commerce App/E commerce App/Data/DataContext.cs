using Microsoft.EntityFrameworkCore;

namespace E_commerce_App.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }

    }
}
