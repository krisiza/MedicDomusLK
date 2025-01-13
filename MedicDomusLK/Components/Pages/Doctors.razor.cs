using MedicDomusLK.Data.Models;
using MedicDomusLK.Services.Contracts;
using Microsoft.AspNetCore.Components;

namespace MedicDomusLK.Components.Pages
{
    public partial class Doctors
    {
        [Inject] private IDoctorInfoService doctorInfoService { get; set; } = null!;

        private List<DoctorInfo> entities = new List<DoctorInfo>();
        protected override async Task OnInitializedAsync()
        {
            entities = doctorInfoService.GetAllAttached()
                .ToList();        
        }
    }
}