using MedicDomusLK.Data.Models;
using MedicDomusLK.Repositories.Contracts;
using MedicDomusLK.Services.Contracts;

namespace MedicDomusLK.Services
{
    public class TownService : ITownService
    {
        private readonly IRepository<Town, int> townRepository;

        public TownService(IRepository<Town, int> townRepository)
        {
            this.townRepository = townRepository;
        }

        public Task<IEnumerable<Town>> GetAllAsync()
            => townRepository.GetAllAsync();
    }
}
