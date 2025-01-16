using MedicDomusLK.Data.Models;
using MedicDomusLK.Services.Contracts;
using MedicDomusLK.ViewModels;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Reflection.Metadata;

namespace MedicDomusLK.Components.Pages
{
    public partial class PdfDownload
    {
        [Parameter] public string BillId { get; set; } = null!;
        [Parameter] public string PatientId { get; set; } = null!;
        [Inject] IApplicationUserService ApplicationUserService { get; set; }
        [Inject] IThisBillService ThisBillService { get; set; }
        [Inject] IInvoiceService InvoiceService { get; set; }
        [Inject] IJSRuntime JsRuntime { get; set; } = null!;
        [Inject] private NavigationManager Navigation { get; set; }

        private ApplicationUser Patient;
        private BillViewModel Bill { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Patient = await ApplicationUserService.GetByIdAsync(PatientId);
            Bill = await ThisBillService.GetByIdAsyc(BillId);
        }
        private async Task DownloadPdf(Microsoft.AspNetCore.Components.Web.MouseEventArgs e)
        {
           byte[] pdfBytes = InvoiceService.GetInvoice(Patient, Bill);
                var fileName = $"{Patient.Lastname}{Patient.Firstname}-Rechnung-von{Bill.Date}.pdf";
                await JsRuntime.InvokeVoidAsync("saveAsFile", fileName, Convert.ToBase64String(pdfBytes));
        }
    }
}
