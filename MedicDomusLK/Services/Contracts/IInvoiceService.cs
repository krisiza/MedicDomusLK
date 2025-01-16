using MedicDomusLK.Data.Models;
using MedicDomusLK.ViewModels;
using PdfSharp.Pdf;
using System;

namespace MedicDomusLK.Services.Contracts
{
    public interface IInvoiceService
    {
        byte[] GetInvoice(ApplicationUser patient, BillViewModel bill);
    }
}
