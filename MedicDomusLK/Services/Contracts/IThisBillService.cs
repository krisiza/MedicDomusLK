using MedicDomusLK.Data.Models;
using MedicDomusLK.ViewModels;

namespace MedicDomusLK.Services.Contracts
{
    public interface IThisBillService
    {
        Task<List<BillViewModel>> GetAllPatientBillsAsync(string patientId);
        void ChangePaidStatus(string billId, bool isPaid);
        Task SaveBillAsync(Bill model);
        Task<BillViewModel> GetByIdAsyc(string id);
    }
}
