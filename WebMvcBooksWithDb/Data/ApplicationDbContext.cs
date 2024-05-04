using Microsoft.EntityFrameworkCore;
using WebMvcBooksWithDb.Models;

namespace WebMvcBooksWithDb.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{

		}
		public DbSet<YeniKitap> YeniKitap { get; set; }
	}
}
