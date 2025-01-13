using Itenso.TimePeriod;
using MedicDomusLK.Data.Models;
using MedicDomusLK.Repositories.Contracts;
using MedicDomusLK.Services.Contracts;
using MedicDomusLK.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace MedicDomusLK.Services
{
    public class DoctorPatientServiceService : IDoctorPatientServiceService
    {
        private readonly IRepository<DoctorPatientService, int> dpsRepository;

        public DoctorPatientServiceService(IRepository<DoctorPatientService, int> dpsRepository)
        {
            this.dpsRepository = dpsRepository;
        }

        public async Task<bool> IsHourFreeAsync(TimeRange timeRange, string doctorId)
        {
          var listentites = await dpsRepository.GetAllAttached()
                .Where(d => d.DoctorId == doctorId)
                .ToListAsync();

            foreach (var item in listentites)
            {
                TimeRange entityRange = new TimeRange(item.DateStart, item.DateEnd);

                if (timeRange.OverlapsWith(entityRange))
                {
                    return false;
                }
            }
            
            return true;    
        }

        public async Task AddDpsEntityAsync(DoctorPatientServiceViewModel model, int serviceId)
        {
            var entity = new DoctorPatientService()
            {
                DoctorId = model.Doctor.Id,
                PatientId = model.Patient.Id,
                ServiceId = serviceId,
                DateStart = model.DateStart,
                DateEnd = model.DateEnd,
            };

           await dpsRepository.AddAsync(entity);
        }
    }
}
