using SigmaVilla_Web.Models.Dto;

namespace SigmaVilla_Web.Services.IServices
{
    public interface IAuthService
    {
        Task<T> LoginAsync<T>(LoginRequestDTO obj);
        Task<T> RegisterAsync<T>(RegistrationRequestDTO obj);
    }
}
