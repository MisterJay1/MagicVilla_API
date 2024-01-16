using SigmaVilla_VillaAPI.Models;
using SigmaVilla_VillaAPI.Models.Dto;

namespace SigmaVilla_VillaAPI.Repository.IRepository
{
    public interface IUserRepository
    {
        bool IsUnique(string username);
        Task<LoginResponseDTO> Login(LoginRequestDTO loginRequestDTO);
        Task<UserDTO> Register(RegistrationRequestDTO registrationRequestDTO);
    }
}
