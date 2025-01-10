using MedicDomusLK.Data.Models;
using MedicDomusLK.Repositories.Contracts;
using MedicDomusLK.Services.Contracts;
using MedicDomusLK.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace MedicDomusLK.Services
{
    public class ApplicationUserService : IApplicationUserService
    {
        private readonly IRepository<ApplicationUser, string> userRepository;


        public ApplicationUserService(IRepository<ApplicationUser, string> userRepository)
        {
            this.userRepository = userRepository;
        }

        public async Task<ApplicationUser?> GetByEmailAsync(string email)
        {
            var user = await userRepository.GetAllAttached()
                .Include(u => u.Town)
                .Where(u => u.Email == email)
                .FirstOrDefaultAsync();

            return user;
        }

        public async Task<ApplicationUser?> GetByIdAsync(string id)
        {
            var user = await userRepository.GetAllAttached()
                .Include(u => u.Town)
                .Where(u => u.Id == id)
                .FirstOrDefaultAsync();

            return user;
        }

        public async Task<bool> UpdateAsync(ApplicationUser item)
            => await userRepository.UpdateAsync(item);

        public bool Update(ApplicationUser item)
         =>  userRepository.Update(item);

        public async Task DeleteAsync(string userId)
        {
            var user = await GetByIdAsync(userId);
            userRepository.Delete(user.Id);
        }

        public async Task<UserProfilViewModel?> ShowUserProfileModelAsync(string id)
        {
            var user = await GetByIdAsync(id);

            if (user == null) return null;

            UserProfilViewModel viewModel = new UserProfilViewModel()
            {
                Firstname = user.Firstname,
                Lastname = user.Lastname,
                Birthdate = user.Birthdate.ToString("dd.MM.yyyy"),
                Gender = user.Gender,
                PostCode = user.Town.PLZ,
                Town = user.Town.Name,
                Street = user.Street,
            };

            return viewModel;
        }

        public IQueryable<ApplicationUser> GetAllAttached()
            => userRepository.GetAllAttached();
    }
}
