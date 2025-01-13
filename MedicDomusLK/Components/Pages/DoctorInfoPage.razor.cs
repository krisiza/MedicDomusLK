using Itenso.TimePeriod;
using MedicDomusLK.Data.Models;
using MedicDomusLK.Services.Contracts;
using MedicDomusLK.ViewModels;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.JSInterop;
using System.Security.Claims;

namespace MedicDomusLK.Components.Pages
{
    public partial class DoctorInfoPage
    {
        [Inject] private IDoctorInfoService DoctorInfoService { get; set; } = null!;
        [Inject] private IServiceService ServiceService { get; set; } = null!;
        [Inject] private AuthenticationStateProvider Provider { get; set; } = null!;
        [Inject] private NavigationManager Navigation { get; set; } = null!;
        [Inject] private IDoctorPatientServiceService DpsService { get; set; } = null!;
        [Inject] IJSRuntime JsRuntime { get; set; } = null!;

        [Parameter]
        public int DoctorId { get; set; }

        [BindProperty] private DoctorPatientServiceViewModel doctorPatientService { get; set; } = new();

        private DoctorInfo? entity;


        private string? UserId;
        private List<Service> services = new();

        protected override async Task OnInitializedAsync()
        {
            var authState = await Provider.GetAuthenticationStateAsync();
            var user = authState.User;

            if (user.Identity != null && user.Identity.IsAuthenticated)
                UserId = user.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            if (!user.Identity?.IsAuthenticated ?? true)
            {
                Navigation.NavigateTo("/login", true);
            }


            doctorPatientService.DateStart = DateTime.Now;

            entity = await DoctorInfoService.GetAllAttached()
                .FirstOrDefaultAsync(u => u.Id == DoctorId);

            services = ServiceService.GetAllAttached().ToList();
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

            var isfree = await DpsService.IsHourFreeAsync(doctorPatientService.TimeRange, entity.Doctor.Id);

            if (!isfree)
            {
                await JsRuntime.InvokeVoidAsync("alert", "Termin ist schon vergeben!");
            }
            else if(doctorPatientService.DateStart.Hour < 7 || doctorPatientService.DateEnd.Hour > 18)
            {
                await JsRuntime.InvokeVoidAsync("alert", "Außerhalb der Arbeitszeit!");
            }
            else if(doctorPatientService.DateStart < DateTime.Now)
            {
                await JsRuntime.InvokeVoidAsync("alert", "Wählen Sie gültiges Datum!");
            }
            else
            {
                var service = services.FirstOrDefault(s => s.Name == doctorPatientService.Service.Name);

                if (service != null)
                {
                    await DpsService.AddDpsEntityAsync(doctorPatientService, service.Id);
                    await JsRuntime.InvokeVoidAsync("alert", $"Ihr Termin für {doctorPatientService.Service.Name} am {doctorPatientService.DateStart} ist gespeicher!");
                    doctorPatientService = new DoctorPatientServiceViewModel
                    {
                        DateStart = DateTime.Now,
                        Service = new()
                    };
                }
                else
                {
                    await JsRuntime.InvokeVoidAsync("alert", $"Service nicht gefunden!");
                }
            }
        }      

    }
}

