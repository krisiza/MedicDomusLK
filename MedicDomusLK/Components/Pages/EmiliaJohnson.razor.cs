using MedicDomusLK.Data.Models;
using MedicDomusLK.Services.Contracts;
using MedicDomusLK.ViewModels;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.JSInterop;
using System.Security.Claims;

namespace MedicDomusLK.Components.Pages
{
    public partial class EmiliaJohnson
    {
        [Inject] private IApplicationUserService applicationUserService { get; set; } = null!;
        [Inject] private IServiceService serviceService { get; set; } = null!;
        [Inject] private AuthenticationStateProvider provider { get; set; } = null!;
        [Inject] private IDoctorPatientServiceService dpsService { get; set; } = null!;
        [Inject] IJSRuntime JsRuntime { get; set; } = null!;

        [BindProperty] private DoctorPatientServiceViewModel doctorPatientService { get; set; } = new();

        private ApplicationUser? doctor;


        private string? UserId;
        private List<Service> services = new();

        protected override async Task OnInitializedAsync()
        {
            var authState = await provider.GetAuthenticationStateAsync();
            var user = authState.User;

            if (user.Identity != null && user.Identity.IsAuthenticated)
                UserId = user.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            doctor = await applicationUserService.GetAllAttached()
                .FirstOrDefaultAsync(u => u.Email == "doctor3@example.com");

            services = serviceService.GetAllAttached().ToList();
            doctorPatientService.Service = new();
        }
        private async Task HandleClick(Microsoft.AspNetCore.Components.Web.MouseEventArgs e)
        {
            bool idfi = await dpsService.IsHourFree(doctorPatientService.DateStart, doctor.Id);
            if (idfi)
            {
                await JsRuntime.InvokeVoidAsync("alert", "Termin ist schon vergeben!");



            }
            doctorPatientService.DateEnd = doctorPatientService.DateStart.AddHours(1);
        }
    }
}
