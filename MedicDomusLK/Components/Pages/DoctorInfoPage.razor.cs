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
    public partial class DoctorInfoPage
    {
        [Inject] private IDoctorInfoService doctorInfoService { get; set; } = null!;
        [Inject] private IServiceService serviceService { get; set; } = null!;
        [Inject] private AuthenticationStateProvider provider { get; set; } = null!;
        [Inject] private IDoctorPatientServiceService dpsService { get; set; } = null!;
        [Inject] IJSRuntime JsRuntime { get; set; } = null!;

        [Parameter]
        public int DoctorId { get; set; }

        [BindProperty] private DoctorPatientServiceViewModel doctorPatientService { get; set; } = new();

        private DoctorInfo? entity;


        private string? UserId;
        private List<Service> services = new();

        protected override async Task OnInitializedAsync()
        {
            doctorPatientService.DateStart = DateTime.Now;
            var authState = await provider.GetAuthenticationStateAsync();
            var user = authState.User;

            if (user.Identity != null && user.Identity.IsAuthenticated)
                UserId = user.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            entity = await doctorInfoService.GetAllAttached()
                .FirstOrDefaultAsync(u => u.Id == DoctorId);

            services = serviceService.GetAllAttached().ToList();
            doctorPatientService.Service = new();
        }
        private async Task HandleClick(Microsoft.AspNetCore.Components.Web.MouseEventArgs e)
        {
            doctorPatientService.Patient = new();
            doctorPatientService.Doctor = new();

            doctorPatientService.DateEnd = doctorPatientService.DateStart.AddHours(1);
            doctorPatientService.Patient.Id = UserId;
            doctorPatientService.Doctor.Id = entity.Doctor.Id;
            doctorPatientService.TimeRange.Start = doctorPatientService.DateStart;
            doctorPatientService.TimeRange.End = doctorPatientService.DateEnd;

            var isfree = await dpsService.IsHourFreeAsync(doctorPatientService.TimeRange, entity.Doctor.Id);

            if (!isfree)
            {
                await JsRuntime.InvokeVoidAsync("alert", "Termin ist schon vergeben!");
            }
            else
            {
                var serviceId = services.FirstOrDefault(s => s.Name == doctorPatientService.Service.Name).Id; ;
                await dpsService.AddDpsEntityAsync(doctorPatientService, serviceId);

                await JsRuntime.InvokeVoidAsync("reloadPage");
                await JsRuntime.InvokeVoidAsync("alert", $"Ihr Termin für {doctorPatientService.Service.Name} am {doctorPatientService.DateStart} ist gespeicher!");
            }
        }      
    }
}

