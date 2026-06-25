using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
            // 자동생성. 내용없음
        }

        public DbSet<Book> Books => Set<Book>();
    }
}
