using MedicDomusLK.Data.Models;
using MedicDomusLK.Repositories.Contracts;
using MedicDomusLK.Services.Contracts;
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

        public Task<bool> IsHourFree(DateTime start, string doctorId)
        {
          return dpsRepository.GetAllAttached()
                .AllAsync(dps => dps.DoctorId == doctorId && dps.DateStart == start);
        }
    }
}
