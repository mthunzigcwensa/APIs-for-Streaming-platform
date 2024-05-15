using youtubeAPis.Models.DTOs;

namespace youtubeAPis.Repositories.IRepositories
{
	public interface IUserRepository
	{
		bool IsUniqueUser(string username);
		Task<TokenDTO> Login(LoginRequestDTO loginRequestDTO);
		Task<UserDTO> Register(RegisterationRequestDTO registerationRequestDTO);
		Task<TokenDTO> RefreshAccessToken(TokenDTO tokenDTO);
		Task RevokeRefreshToken(TokenDTO tokenDTO);
	}
}
