using MedicDomusLK.Data.Models;
using MedicDomusLK.Services.Contracts;
using MedicDomusLK.ViewModels;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace MedicDomusLK.Components.Pages
{
    public partial class UserProfileEdit
    {
        [Inject] private UserManager<ApplicationUser> UserManager { get; set; } = null!;
        [Inject] private SignInManager<ApplicationUser> SignInManager { get; set; } = null!;
        [Inject] private NavigationManager NavigationManager { get; set; } = null!;
        [Inject] private AuthenticationStateProvider Provider { get; set; } = null!;
        [Inject] private IApplicationUserService ApplicationUserService { get; set; } = null!;

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

            Towns = new List<Town>()
            {
                   new Town { Id = 1, PLZ = "93047", Name = "Regensburg" },
                   new Town { Id = 2, PLZ = "92318", Name = "Neumarkt in der Oberpfalz" },
                   new Town { Id = 3, PLZ = "92224", Name = "Amberg" },
                   new Town { Id = 4, PLZ = "92237", Name = "Sulzbach-Rosenberg" },
                   new Town { Id = 5, PLZ = "92703", Name = "Leuchtenberg" },
                   new Town { Id = 6, PLZ = "93059", Name = "Regensburg-West" },
                   new Town { Id = 7, PLZ = "92334", Name = "Berching" },
                   new Town { Id = 8, PLZ = "92421", Name = "Schwandorf" },
                   new Town { Id = 9, PLZ = "92339", Name = "Beilngries" },
                   new Town { Id = 10, PLZ = "92271", Name = "Hirschau" },
                   new Town { Id = 11, PLZ = "92271", Name = "Freudenberg" },
                   new Town { Id = 12, PLZ = "92353", Name = "Postbauer-Heng" },
                   new Town { Id = 13, PLZ = "92718", Name = "Vohenstrauß" },
                   new Town { Id = 14, PLZ = "93073", Name = "Wenzenbach" },
                   new Town { Id = 15, PLZ = "92442", Name = "Oberviechtach" },
                   new Town { Id = 16, PLZ = "93413", Name = "Cham" },
                   new Town { Id = 17, PLZ = "93444", Name = "Bad Kötzting" },
                   new Town { Id = 18, PLZ = "92266", Name = "Ensdorf" },
                   new Town { Id = 19, PLZ = "92431", Name = "Neunburg vorm Wald" },
                   new Town { Id = 20, PLZ = "93092", Name = "Barbing" },
                   new Town { Id = 21, PLZ = "92699", Name = "Wiesau" },
                   new Town { Id = 22, PLZ = "92439", Name = "Bodenwöhr" }
            };
        }
    }
}
