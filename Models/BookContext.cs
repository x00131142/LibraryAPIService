using Microsoft.EntityFrameworkCore;

namespace LibraryAPIService.Models
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Book { get; set; }
        //public DbSet<Author> Authors { get; set; }

/*
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookAuthor>()
                .HasKey(a => new { a.AuthorID, a.ISBN });

            modelBuilder.Entity<BookAuthor>()
                .HasOne(b => b.Author)
                .WithMany(bk => bk.BookAuthors)
                .HasForeignKey(b => b.AuthorID);

            modelBuilder.Entity<BookAuthor>()
                .HasOne(b => b.Book)
                .WithMany(bk => bk.BookAuthors)
                .HasForeignKey(b => b.ISBN);
        }
*/
    }
}