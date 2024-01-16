using SigmaVilla_VillaAPI.Models;
using System.Linq.Expressions;

namespace SigmaVilla_VillaAPI.Repository.IRepository
{
    public interface IVillaNumberRepository : IRepository<VillaNumber>
    {
        Task<VillaNumber> UpdateAsync(VillaNumber entity);
    }
}
