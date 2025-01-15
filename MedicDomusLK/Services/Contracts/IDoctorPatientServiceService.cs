using Itenso.TimePeriod;
using MedicDomusLK.Data.Models;
using MedicDomusLK.ViewModels;

namespace MedicDomusLK.Services.Contracts
{
    public interface IDoctorPatientServiceService
    {
        Task<bool> IsHourFreeAsync(TimeRange timerange, string doctorId);
        Task AddDpsEntityAsync(DoctorPatientServiceViewModel model, int serviceId);
        Task<List<AppontmentViewModel>> GetAppoinsments(string userId);
        Task<List<AppontmentViewModel>> GetAppoinsmentsDoctor(string userId);
        Task DeleteAppointment(string doctorId, string userId, int serviceId, DateTime date);
        Task<AppontmentViewModel?> FindAppointment(string doctorId, string userId, int serviceId, DateTime date);
    }
}
