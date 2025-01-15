using MedicDomusLK.Services.Contracts;
using MedicDomusLK.ViewModels;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.JSInterop;
using System.Security.Claims;

namespace MedicDomusLK.Components.Pages
{
    public partial class DeleteAppointment
    {
        [Inject] private NavigationManager Navigation {  get; set; }
        [Inject] IJSRuntime JsRuntime { get; set; } = null!;
        [Inject] private IDoctorPatientServiceService PatientService { get; set; }
        [Inject] private AuthenticationStateProvider Provider { get; set; } = null!;

        [Parameter] public string DoctorId { get; set; }
        [Parameter] public int ServiceId { get; set; }
        [Parameter] public string UserId { get; set; }
        [Parameter] public DateTime DateStart { get; set; }

        [BindProperty]
        public AppontmentViewModel? Appontment { get; set; } = null!;

        private ClaimsPrincipal? User;

        protected override async Task OnInitializedAsync()
        {
            var authState = await Provider.GetAuthenticationStateAsync();
            User = authState.User;

            var uri = Navigation.ToAbsoluteUri(Navigation.Uri);
            var query = System.Web.HttpUtility.ParseQueryString(uri.Query);

            DoctorId = query["doctorId"];
            ServiceId = int.Parse(query["serviceId"]);
            UserId = query["userId"];
            DateStart = DateTime.Parse(query["dateStart"]);

            Appontment = await PatientService.FindAppointment(DoctorId,UserId, ServiceId, DateStart);
        }
        private void NoClicked(Microsoft.AspNetCore.Components.Web.MouseEventArgs e)
        {
            Navigation.NavigateTo("/appointment");
        }
        private async void YesClicked(Microsoft.AspNetCore.Components.Web.MouseEventArgs e)
        {
            await PatientService.DeleteAppointment(DoctorId, UserId, ServiceId, DateStart);
            await JsRuntime.InvokeVoidAsync("alert", $"Der Termin am {DateStart} wurde erfolgreich gelöscht!");
            Navigation.NavigateTo("/appointment");
        }
    }
}
