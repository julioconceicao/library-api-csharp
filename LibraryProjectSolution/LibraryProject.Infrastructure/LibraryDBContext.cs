using Microsoft.EntityFrameworkCore;
using LibraryProject.Core;

namespace LibraryProject.Infrastructure
{
    public class LibraryDBContext : DbContext
    {
        public LibraryDBContext(DbContextOptions<LibraryDBContext> opt) : base(opt)
        {
        }
        public DbSet<BookModel> Books { get; set; }
    }
}