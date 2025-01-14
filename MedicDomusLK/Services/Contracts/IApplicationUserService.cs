using MedicDomusLK.Data.Models;
using MedicDomusLK.ViewModels;

namespace MedicDomusLK.Services.Contracts
{
    public interface IApplicationUserService
    {
        Task DeleteAsync(string userId);
        Task<UserProfilViewModel?> ShowUserProfileModelAsync(string id);
        Task<bool> UpdateAsync(ApplicationUser item);
        public bool Update(ApplicationUser item);
        Task<ApplicationUser?> GetByIdAsync(string id);
        Task<ApplicationUser?> GetByEmailAsync(string email);
        IQueryable<ApplicationUser> GetAllAttached();
        Task<List<ApplicationUser>?> GetUsersWithNoRolesAsync();
    }
}
