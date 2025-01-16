using MedicDomusLK.Services.Contracts;
using MedicDomusLK.ViewModels;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace MedicDomusLK.Components.Pages
{
    public partial class BillsPage
    {
        [Inject] IThisBillService ThisBillService { get; set; }
        [Inject] private AuthenticationStateProvider Provider { get; set; } = null!;
        [Inject] private NavigationManager Navigation { get; set; }
        [BindProperty] public List<BillViewModel>? Bills { get; set; } = null!;
        [Parameter] public string PatientId { get; set; }

        private ClaimsPrincipal? User;
        private string? UserId;
        private bool isUserAuthenticated;
        protected override async Task OnInitializedAsync()
        {
            var authState = await Provider.GetAuthenticationStateAsync();
            User = authState.User;

            if (User.Identity != null && User.Identity.IsAuthenticated)
            {
                UserId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            }

            isUserAuthenticated = User.Identity.IsAuthenticated;

            var uri = Navigation.ToAbsoluteUri(Navigation.Uri);
            var query = System.Web.HttpUtility.ParseQueryString(uri.Query);

            PatientId = query["patientId"];

            Bills = await ThisBillService.GetAllPatientBillsAsync(PatientId);
        }

        private void CheckboxChanged(string billId, bool isPaid)
        {
            ThisBillService.ChangePaidStatus(billId, !isPaid);
        }
    }
}
