using SigmaVilla_Web.Models;

namespace SigmaVilla_Web.Services.IServices
{
    public interface IBaseService
    {
        APIResponse responseModel { get; set; }
        Task<T> SendAsync<T>(APIRequest aPIRequest);
    }
}
