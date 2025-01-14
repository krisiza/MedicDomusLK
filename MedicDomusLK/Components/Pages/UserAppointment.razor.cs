using MedicDomusLK.Data.Models;
using MedicDomusLK.Services;
using MedicDomusLK.Services.Contracts;
using MedicDomusLK.ViewModels;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace MedicDomusLK.Components.Pages
{
    public partial class UserAppointment
    {
        [Inject] private IDoctorPatientServiceService dpsService { get; set; } = null!;
        [Inject] private AuthenticationStateProvider Provider { get; set; } = null!;

        private List<AppontmentViewModel> appontments;
        private string? UserId;
        protected override async Task OnInitializedAsync()
        {
            var authState = await Provider.GetAuthenticationStateAsync();
            var user = authState.User;

            if (user.Identity != null && user.Identity.IsAuthenticated)
            {
                UserId = user.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            }

            appontments = await dpsService.GetAppoinsments(UserId);
        }
    }
}
