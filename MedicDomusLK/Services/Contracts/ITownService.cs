using MedicDomusLK.Data.Models;

namespace MedicDomusLK.Services.Contracts
{
    public interface ITownService
    {
        Task<IEnumerable<Town>> GetAllAsync();
    }
}
