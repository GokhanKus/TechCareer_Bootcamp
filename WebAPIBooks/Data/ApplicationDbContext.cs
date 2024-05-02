using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using WebAPIBooks.Models;

namespace WebAPIBooks.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Book> Book { get; set; }

    }
}
