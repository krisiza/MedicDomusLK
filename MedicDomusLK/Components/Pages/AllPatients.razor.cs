using MedicDomusLK.Data.Models;
using MedicDomusLK.Services.Contracts;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Mvc;

namespace MedicDomusLK.Components.Pages
{
    public partial class AllPatients
    {
        [Inject] private IApplicationUserService ApplicationUserService { get; set; } = null!;

        [BindProperty] public List<ApplicationUser>? Users { get; set; } = null!;
        [BindProperty] public ApplicationUser? User { get; set; } = new();
        protected override async Task OnInitializedAsync()
        {
            Users = await ApplicationUserService.GetUsersWithNoRolesAsync();
        }
    }
}
