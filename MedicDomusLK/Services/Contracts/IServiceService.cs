using MedicDomusLK.Data.Models;

namespace MedicDomusLK.Services.Contracts
{
    public interface IServiceService
    {
        IQueryable<Service> GetAllAttached();
    }
}
