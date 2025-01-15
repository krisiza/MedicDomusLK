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
        private ClaimsPrincipal? User;
        protected override async Task OnInitializedAsync()
        {
            var authState = await Provider.GetAuthenticationStateAsync();
            User = authState.User;

            if (User.Identity != null && User.Identity.IsAuthenticated)
            {
                UserId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            }

            if (User.IsInRole("Doctor"))
                appontments = await dpsService.GetAppoinsmentsDoctor(UserId);
            else
                appontments = await dpsService.GetAppoinsments(UserId);
        }
    }
}
