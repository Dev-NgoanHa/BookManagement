using BookManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace BookManagement.Context
{
    public class BookManagementDbContext : DbContext
    {
        public BookManagementDbContext(DbContextOptions<BookManagementDbContext> options) : base(options)
        {
 
        }

        public DbSet<Book> Books { get; set; }
    }
}
