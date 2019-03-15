using Microsoft.EntityFrameworkCore;

namespace LibraryAPI.Models
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options)
            : base(options)
        {
        }

        public DbSet<BookContext> Books { get; set; }
    }
}