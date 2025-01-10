using MedicDomusLK.Data.Models;
using MedicDomusLK.Repositories.Contracts;
using MedicDomusLK.Services.Contracts;

namespace MedicDomusLK.Services
{
    public class ServiceService : IServiceService
    {
        private readonly IRepository<Service,int> serviceRepository;

        public ServiceService(IRepository<Service, int> serviceRepository)
        {
            this.serviceRepository = serviceRepository;
        }

        public IQueryable<Service> GetAllAttached()
            => serviceRepository.GetAllAttached();
    }
}
