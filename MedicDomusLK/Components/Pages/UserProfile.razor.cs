using MedicDomusLK.Data.Models;
using MedicDomusLK.Services.Contracts;
using MedicDomusLK.ViewModels;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace MedicDomusLK.Components.Pages
{
    public partial class UserProfile 
    {
        [Inject] private UserManager<ApplicationUser> UserManager { get; set; } = null!;
        [Inject] private SignInManager<ApplicationUser> SignInManager { get; set; } = null!;
        [Inject] private NavigationManager NavigationManager { get; set; } = null!;
        [Inject] private AuthenticationStateProvider Provider { get; set; } = null!;
        [Inject] private IApplicationUserService ApplicationUserService { get; set; } = null!;

        [BindProperty]
        public UserProfilViewModel? ApplicationUser { get; set; } = null!;

        private string? UserId;

        protected override async Task OnInitializedAsync()
        {
            var authState = await Provider.GetAuthenticationStateAsync();
            var user = authState.User;

            if (user.Identity != null && user.Identity.IsAuthenticated)
            {
                UserId = user.FindFirst(ClaimTypes.NameIdentifier)?.Value;
                ApplicationUser = await ApplicationUserService.ShowUserProfileModelAsync(UserId);
            }
            
        }
    }
}
