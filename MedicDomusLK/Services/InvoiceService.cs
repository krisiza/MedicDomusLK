using PdfSharp.Pdf;
using PdfSharp.Drawing;
using MedicDomusLK.Services.Contracts;
using MigraDoc.DocumentObjectModel;
using MigraDoc.Rendering;
using MigraDoc.DocumentObjectModel.Tables;
using MedicDomusLK.ViewModels;
using MedicDomusLK.Data.Models;
using MedicDomusLK.Data.Models.Enums;
using MigraDoc.DocumentObjectModel.Shapes;

namespace MedicDomusLK.Services
{
    public class InvoiceService : IInvoiceService
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public InvoiceService(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }
        public byte[] GetInvoice(ApplicationUser patient, BillViewModel bill)
        {
            var document = new Document();

            BuildDocument(document, patient, bill);

            var pdfRenderer = new PdfDocumentRenderer();
            pdfRenderer.Document = document;

            pdfRenderer.RenderDocument();

            PdfDocument pdf = pdfRenderer.PdfDocument;

            using (var memoryStream = new MemoryStream())
            {
                pdf.Info.Title = "Generated with PDFsharp";

                PdfPage page = pdf.AddPage();
                XGraphics gfx = XGraphics.FromPdfPage(page);


                pdf.Save(memoryStream);
                return memoryStream.ToArray();
            }
        }

        private void BuildDocument(Document document, ApplicationUser patient, BillViewModel bill)
        {
            Section section = document.AddSection();

            string imagePath = Path.Combine(_webHostEnvironment.WebRootPath, "logo.png");
            var image = section.AddImage(imagePath); 
            image.Width = "5cm"; 
            image.Height = "2cm"; 
            image.LockAspectRatio = true; 
            image.RelativeVertical = RelativeVertical.Line;
            image.RelativeHorizontal = RelativeHorizontal.Margin;
            image.Top = ShapePosition.Top;
            image.Left = ShapePosition.Center;
            image.WrapFormat.Style = WrapStyle.Through;

            var paragraph = section.AddParagraph();
            paragraph.Format.SpaceBefore = "40pt";
            paragraph.AddText("MedicDomus");
            paragraph.AddLineBreak();
            paragraph.AddText("Luitpoldstraße 16");
            paragraph.AddLineBreak();
            paragraph.AddText("93047 Regensburg");
            paragraph.AddLineBreak();
            paragraph.AddText("E-Mail: medic@domus.de");
            paragraph.AddLineBreak();
            paragraph.AddText("Telefonnummer: 0941 47355");
            paragraph.Format.Alignment = ParagraphAlignment.Right;
            paragraph.Format.SpaceAfter = 20;

            paragraph = section.AddParagraph();
            if (patient.Gender == Gender.Male) 
                paragraph.AddText($"Herr {patient.Lastname} {patient.Firstname}");
            else if (patient.Gender == Gender.Female)
                paragraph.AddText($"Frau {patient.Lastname} {patient.Firstname}");
            else
                paragraph.AddText($"{patient.Lastname} {patient.Firstname}");

            paragraph.AddLineBreak();
            paragraph.AddText(patient.Street);
            paragraph.AddLineBreak();
            paragraph.AddText($"{patient.Town.PLZ} {patient.Town.Name}");
            paragraph.Format.Alignment = ParagraphAlignment.Left;
            paragraph.Format.SpaceAfter = 50;
            paragraph = section.AddParagraph();

            paragraph.AddText($"Darum: {bill.Date.ToString("dd.MM.yyyy")}");
            paragraph.Format.Alignment = ParagraphAlignment.Right;
            paragraph.Format.SpaceAfter = 50;

            paragraph = section.AddParagraph();
            paragraph.AddText($"Rechnungnr: {bill.Id.ToUpper()}");
            paragraph.Format.Font.Size = 14;
            paragraph.Format.Font.Bold = true;
            paragraph.Format.Alignment = ParagraphAlignment.Center;
            paragraph.Format.SpaceAfter = 50;

            var table = document.LastSection.AddTable();
            table.Borders.Width = 0.5;

            table.AddColumn("1cm");
            table.AddColumn("13cm");
            table.AddColumn("4cm");
            table.Borders.Visible = false;

            Row row = table.AddRow();
            row.HeadingFormat = true;
            row.Format.Font.Bold = true;
            row.Cells[0].AddParagraph("Nr.");
            row.Cells[1].AddParagraph("Dienstleistung");
            row.Cells[2].AddParagraph("Price");

            for (int i = 0; i < bill.Services.Count; i++)
            {
                row = table.AddRow();
                row.Cells[0].AddParagraph((i+1).ToString());
                row.Cells[1].AddParagraph(bill.Services[i].Name);
                row.Cells[2].AddParagraph(bill.Services[i].Price.ToString());
            }

            paragraph = section.AddParagraph();
            paragraph.AddText($"Gesamt: {bill.Price.ToString("f2")}");
            paragraph.Format.Alignment = ParagraphAlignment.Right;
            paragraph.Format.SpaceAfter = 30;

            paragraph = section.Footers.Primary.AddParagraph();
            paragraph.AddText("MedicDomus");
            paragraph.AddText("Vertrauen, Kompetenz und Fürsorge – Seit 40 Jahren für Sie da");
            paragraph.AddText("Luitpoldstraße 16, 93047 Regensburg");
            paragraph.Format.Alignment = ParagraphAlignment.Center;
        }

        void DrawImage(XGraphics gfx, string jpegSamplePath, int x, int y, int width, int height)
        {
            XImage image = XImage.FromFile(jpegSamplePath);
            gfx.DrawImage(image, x, y, width, height);
        }
    }
}
