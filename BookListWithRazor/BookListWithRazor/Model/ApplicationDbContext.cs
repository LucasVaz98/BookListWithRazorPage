using Microsoft.EntityFrameworkCore;

namespace BookListWithRazor.Model
{
    public class ApplicationDbContext : DbContext
    {   
        // ctor then tab tab - snippet for the constructor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Book> Books{ get; set; }
    }
}
