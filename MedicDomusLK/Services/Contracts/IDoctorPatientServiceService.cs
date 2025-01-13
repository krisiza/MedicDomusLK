using Itenso.TimePeriod;
using MedicDomusLK.Data.Models;
using MedicDomusLK.ViewModels;

namespace MedicDomusLK.Services.Contracts
{
    public interface IDoctorPatientServiceService
    {
        Task<bool> IsHourFreeAsync(TimeRange timerange, string doctorId);
        Task AddDpsEntityAsync(DoctorPatientServiceViewModel model, int serviceId);
    }
}
