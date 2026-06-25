using Microsoft.EntityFrameworkCore;

public class Models_(DbContextOptions<Models_> options) : DbContext(options)
{
    public DbSet<WebApplication1.Models.Book> Book { get; set; } = default!;
}
