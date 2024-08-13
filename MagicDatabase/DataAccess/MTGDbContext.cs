using MagicDatabaseUI.Entities;
using Microsoft.EntityFrameworkCore;

namespace MagicDatabaseUI.DataAccess
{
	public class MTGDbContext : DbContext
	{
		public DbSet<Card> Cards { get; set; }
		public DbSet<Color> Colors { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("DefaultConnecion");
		}
	}
}
