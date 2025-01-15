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
        private readonly IRepository<DoctorPatientService, (string, string, int, DateTime)> dpsRepository;
        private readonly IRepository<DoctorInfo, int> dInfoRepository;

        public DoctorPatientServiceService(IRepository<DoctorPatientService, (string, string, int, DateTime)> dpsRepository,
             IRepository<DoctorInfo, int> dInfoRepository)
        {
            this.dpsRepository = dpsRepository;
            this.dInfoRepository = dInfoRepository;
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

        public async Task<List<AppontmentViewModel>> GetAppoinsments(string userId)
        {
            var entites = await dpsRepository.GetAllAttached()
                .Include(d => d.Doctor)
                .Include(d => d.Service)
                .Where(d => d.PatientId == userId)
                .Select(d => new AppontmentViewModel()
                {
                    Doctor = d.Doctor,
                    Service = d.Service,
                    DateStart = d.DateStart,
                })
                .ToListAsync();

            var doctorInfos = await dInfoRepository.GetAllAttached()
                .ToListAsync();

            foreach(var doctorInfo in doctorInfos)
            {
                foreach(var entity  in entites)
                {
                    if(doctorInfo.DoctorId == entity.Doctor.Id)
                    {
                        entity.Sector = doctorInfo.Sector;
                        entity.Img = doctorInfo.Img;
                    }
                }
            }

            return entites;
        }

        public async Task<List<AppontmentViewModel>> GetAppoinsmentsDoctor(string userId)
        {
            var entites = await dpsRepository.GetAllAttached()
                .Include(d => d.Patient)
                .Include(d => d.Service)
                .Where(d => d.DoctorId == userId)
                .Select(d => new AppontmentViewModel()
                {
                    Patient = d.Patient,
                    Service = d.Service,
                    DateStart = d.DateStart,
                })
                .ToListAsync();

            return entites;
        }

        public async Task<AppontmentViewModel?> FindAppointment(string doctorId, string userId, int serviceId, DateTime date)
        {
            var model = await dpsRepository.GetAllAttached()
                .Where(d => d.ServiceId == serviceId && d.PatientId == userId && d.DoctorId == doctorId && d.DateStart == date)
                .Include(d => d.Doctor)
                .Include (d => d.Service)
                .Select (d => new AppontmentViewModel()
                {
                    Patient = d.Patient,
                    Doctor = d.Doctor,
                    Service = d.Service,
                    DateStart = d.DateStart,
                })
                .FirstOrDefaultAsync();

            var doctorInfo = await dInfoRepository.GetAllAttached()
                .FirstOrDefaultAsync(d => d.DoctorId == doctorId);

            model.Img = doctorInfo.Img;
            model.Sector = doctorInfo.Sector;

            return model;
        }

        public async Task DeleteAppointment(string doctorId, string userId, int serviceId, DateTime date)
        {
            var entity = await dpsRepository.GetAllAttached()
                .FirstOrDefaultAsync(d => d.ServiceId == serviceId && d.PatientId == userId && d.DoctorId == doctorId && d.DateStart == date);
            
            if(entity != null) 
               await dpsRepository.DeleteEntityAsync(entity);
        }
    }
}
