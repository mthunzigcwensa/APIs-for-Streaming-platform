using AutoMapper;
using youtubeAPis.Models.DTOs;
using youtubeAPis.Models;

namespace youtubeAPis
{
	public class MappingConfig : Profile
	{
		public MappingConfig() {

			CreateMap<ApplicationUser, UserDTO>().ReverseMap();

		}
	}
}
