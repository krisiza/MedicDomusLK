using MedicDomusLK.Data.Models;
using MedicDomusLK.Repositories.Contracts;
using MedicDomusLK.Services.Contracts;
using Microsoft.EntityFrameworkCore;

namespace MedicDomusLK.Services
{
    public class DoctorInfoService : IDoctorInfoService
    {
        private readonly IRepository<DoctorInfo, int> repository;

        public DoctorInfoService(IRepository<DoctorInfo, int> repository)
        {
            this.repository = repository;
        }

        public IQueryable<DoctorInfo> GetAllAttached()
            => repository.GetAllAttached()
            .Include(d => d.Doctor);
    }
}
