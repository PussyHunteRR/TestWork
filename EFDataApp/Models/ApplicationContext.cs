using Microsoft.EntityFrameworkCore;

namespace EFDataApp.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();   
        }
    }
}