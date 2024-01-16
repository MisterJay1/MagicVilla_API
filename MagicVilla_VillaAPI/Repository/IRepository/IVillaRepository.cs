using SigmaVilla_VillaAPI.Models;
using System.Linq.Expressions;

namespace SigmaVilla_VillaAPI.Repository.IRepository
{
    public interface IVillaRepository : IRepository<Villa>
    {
        Task<Villa> UpdateAsync(Villa entity);
    }
}
