using MedicDomusLK.Services.Contracts;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components;
using System.Security.Claims;
using MedicDomusLK.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.JSInterop;

namespace MedicDomusLK.Components.Pages
{
    public partial class CreateBill
    {
        [Inject] IThisBillService ThisBillService { get; set; }
        [Inject] IApplicationUserService ApplicationUserService { get; set; }
        [Inject] IServiceService ServiceService { get; set; }
        [Inject] private AuthenticationStateProvider Provider { get; set; } = null!;
        [Inject] private NavigationManager Navigation { get; set; }
        [Inject] IJSRuntime JsRuntime { get; set; } = null!;
        [Parameter] public string PatientId { get; set; }
        [Parameter] public string Price { get; set; } = "";

        private ClaimsPrincipal? User;
        private string? UserId;

        private Bill bill = new();

        private List<ApplicationUser> doctors;
        private List<Service> services;
        private ApplicationUser patient;
        private int serviceId;
        private decimal price;
        private List<Service> addedServices = new();
        private Service service = new();
        protected override async Task OnInitializedAsync()
        {
            var authState = await Provider.GetAuthenticationStateAsync();
            User = authState.User;

            if (User.Identity != null && User.Identity.IsAuthenticated)
            {
                UserId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            }

            patient = await ApplicationUserService.GetByIdAsync(PatientId);
            doctors = await ApplicationUserService.GetAllDoctorsAsync();
            services = await ServiceService.GetAllAttached().ToListAsync();
            bill.Doctor = doctors.ToList().First(d => d.Id == UserId);
            bill.DoctorId = UserId;
        }

        public async Task HandleValidSubmit()
        {
            bill.Date = DateTime.Now;
            bill.Patient = patient;
            bill.PatientId = bill.Patient.Id;
            bill.Doctor = doctors.ToList().First(d => d.Id == bill.DoctorId);
            bill.Services = addedServices;
            bill.Price = price;
            bill.Id = Guid.NewGuid().ToString();

            await ThisBillService.SaveBillAsync(bill);
            await JsRuntime.InvokeVoidAsync("alert", "Die Rechnung ist gespreichert!");
            Navigation.NavigateTo("/allPatients");
        }

        public async Task AddService()
        {
            if (serviceId == 0)
                return;

            var selectedService = services.FirstOrDefault(s => s.Id == serviceId);
            addedServices.Add(selectedService);
            price = addedServices.Sum(s => s.Price);
            Price = price.ToString();
        }
    }
}
