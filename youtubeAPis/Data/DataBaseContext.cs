using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using youtubeAPis.Models;

namespace youtubeAPis.Data
{
	public class DataBaseContext : IdentityDbContext<ApplicationUser>
	{
		public DataBaseContext(DbContextOptions<DataBaseContext> options)
			: base(options)
		{
		}

		public DbSet<ApplicationUser> ApplicationUsers { get; set; }

		public DbSet<LocalUser> LocalUsers { get; set; }
		public DbSet<RefreshToken> RefreshTokens { get; set; }

	}
}
