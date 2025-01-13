using MedicDomusLK.Data.Models;

namespace MedicDomusLK.Services.Contracts
{
    public interface IDoctorInfoService
    {
        IQueryable<DoctorInfo> GetAllAttached();
    }
}
