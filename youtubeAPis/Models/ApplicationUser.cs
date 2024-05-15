using Microsoft.AspNetCore.Identity;

namespace youtubeAPis.Models
{
	public class ApplicationUser : IdentityUser
	{
		public string Name { get; set; }
	}
}
