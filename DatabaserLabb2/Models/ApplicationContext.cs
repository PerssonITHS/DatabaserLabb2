using Microsoft.EntityFrameworkCore;

namespace DatabaserLabb2.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
        : base(options)
        {

        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Book>().HasMany(b => b.Authors).WithOne(b => b.Books)
        //        .HasForeignKey(b => b.AuthorId);

        //    modelBuilder.Entity<Author>().HasMany(a => a.Books).WithOne(a => a.Author)
        //        .HasForeignKey(a => a.BookId);
        //}
    }
}
