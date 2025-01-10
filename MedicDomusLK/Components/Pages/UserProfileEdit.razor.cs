using MedicDomusLK.Data.Models;
using MedicDomusLK.Services.Contracts;
using MedicDomusLK.ViewModels;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace MedicDomusLK.Components.Pages
{
    public partial class UserProfileEdit
    {
        [Inject] private UserManager<ApplicationUser> UserManager { get; set; } = null!;
        [Inject] private SignInManager<ApplicationUser> SignInManager { get; set; } = null!;
        [Inject] private NavigationManager NavigationManager { get; set; } = null!;
        [Inject] private AuthenticationStateProvider Provider { get; set; } = null!;
        [Inject] private IApplicationUserService ApplicationUserService { get; set; } = null!;
        [Inject] private ITownService townService { get; set; }

        [BindProperty]
        public UserProfilViewModel? ApplicationUser { get; set; } = null!;

        private string? UserId;

        private IEnumerable<Town> Towns { get; set; } = Enumerable.Empty<Town>();

        protected override async Task OnInitializedAsync()
        {
            var authState = await Provider.GetAuthenticationStateAsync();
            var user = authState.User;

            if (user.Identity != null && user.Identity.IsAuthenticated)
            {
                UserId = user.FindFirst(ClaimTypes.NameIdentifier)?.Value;
                ApplicationUser = await ApplicationUserService.ShowUserProfileModelAsync(UserId);
            }

            Towns = await townService.GetAllAsync();
        }

        private async Task HandleButtonClick()
        {
            ApplicationUser? user = await ApplicationUserService.GetByIdAsync(UserId);

            if (user == null) return;

            user.Firstname = ApplicationUser.Firstname;
            user.Lastname = ApplicationUser.Lastname;

            DateTime birthdate;
            if(DateTime.TryParse(ApplicationUser.Birthdate, out birthdate))
                user.Birthdate = DateTime.Parse(ApplicationUser.Birthdate);

            user.TownId = Towns.FirstOrDefault(t => t.Name == ApplicationUser.Town).Id;
            user.Street = ApplicationUser.Street;
            user.Gender = ApplicationUser.Gender;

            await ApplicationUserService.UpdateAsync(user);
            NavigationManager.NavigateTo("/profile");
        }
    }
}
