using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components;
using System.Security.Claims;

namespace MedicDomusLK.Components.Pages
{
    public partial class Home
    {
        [Inject] private AuthenticationStateProvider Provider { get; set; } = null!;

        private ClaimsPrincipal? User;
        private string? UserId;
        protected override async Task OnInitializedAsync()
        {
            var authState = await Provider.GetAuthenticationStateAsync();
            User = authState.User;

            if (User.Identity != null && User.Identity.IsAuthenticated)
            {
                UserId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            }
        }
    }
}
