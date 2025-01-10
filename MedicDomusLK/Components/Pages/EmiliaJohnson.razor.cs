using MedicDomusLK.Data.Models;
using MedicDomusLK.Services;
using MedicDomusLK.Services.Contracts;
using MedicDomusLK.ViewModels;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace MedicDomusLK.Components.Pages
{
    public partial class EmiliaJohnson
    {
        [Inject] private IApplicationUserService applicationUserService { get; set; } = null!;
        [Inject] private IServiceService serviceService { get; set; } = null!;
        [Inject] private AuthenticationStateProvider Provider { get; set; } = null!;

        [BindProperty] private DoctorPatientService doctorPatientService { get; set; } = new() { Service = new Service() };


        private string? UserId;
        private List<Service> services = new();

        protected override async Task OnInitializedAsync()
        {
            var authState = await Provider.GetAuthenticationStateAsync();
            var user = authState.User;

            if (user.Identity != null && user.Identity.IsAuthenticated)
                UserId = user.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            var doctor = await applicationUserService.GetAllAttached()
                .FirstOrDefaultAsync(u => u.Email == "doctor3@example.com");

            services = serviceService.GetAllAttached().ToList();
        }
        private void HandleButtonClick(Microsoft.AspNetCore.Components.Web.MouseEventArgs e)
        {
            ;

        }
        private Task ButtonClicked(Microsoft.AspNetCore.Components.Web.MouseEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
