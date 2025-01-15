using MedicDomusLK.Data.Models;
using MedicDomusLK.Repositories.Contracts;
using MedicDomusLK.Services.Contracts;
using MedicDomusLK.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace MedicDomusLK.Services
{
    public class ThisBillService : IThisBillService
    {
        private readonly IRepository<Bill, string> billRepository;
        private readonly IRepository<BillService, (string,int)> billServiceRepository;
        private readonly IServiceService serviceService;

        public ThisBillService(IRepository<Bill, string> billRepository, 
            IRepository<BillService, (string, int)> billServiceRepository,
            IServiceService serviceService)
        {
            this.billRepository = billRepository;
            this.billServiceRepository = billServiceRepository;
            this.serviceService = serviceService;
        }

        public async Task<List<BillViewModel>> GetAllPatientBillsAsync(string patientId)
        {
            var billServives = await billServiceRepository
                .GetAllAttached()
                .Include(bs => bs.Service) 
                .ToListAsync();

            var models = billRepository.GetAllAttached()
                .Include(b => b.Patient)
                .Include(b => b.Doctor)
                .Where(b =>  b.PatientId == patientId)
                .Select(b => new BillViewModel()
                {
                    Id = b.Id,
                    Patient = b.Patient,    
                    Doctor = b.Doctor,
                    Paid = b.Paid,
                    Price = b.Price,
                    Date = b.Date,
                })
                .ToList();

            foreach(var bill in models)
            {
                foreach(var bs in billServives)
                {
                    if (bill.Id == bs.BillId)
                    {
                        bill.Services.Add(bs.Service);
                    }
                }
            }

            return models;
        }

        public void ChangePaidStatus(string billId ,bool isPaid)
        {
            var entity = billRepository.GetById(billId);
            entity.Paid = isPaid;
            billRepository.Update(entity);
        }
    }
}
