using FIrstProject.Model;
using Microsoft.EntityFrameworkCore;

namespace FIrstProject.Data
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options):base(options) 
        {
            
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Book> Tbl_Books { get; set; }
        public DbSet<BookCover> Tbl_BookCovers { get; set; }
        public DbSet<BookWritters> Tbl_BookWritters { get; set; }
    }
}
