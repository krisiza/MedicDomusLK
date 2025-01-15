using MedicDomusLK.Data.Models;

namespace MedicDomusLK.Services.Contracts
{
    public interface IServiceService
    {
        IQueryable<Service> GetAllAttached();
        Task<Service> FindById(int id);
    }
}
