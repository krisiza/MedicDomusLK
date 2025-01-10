using MedicDomusLK.Services.Contracts;
using Microsoft.AspNetCore.Components;

namespace MedicDomusLK.Components.Pages
{
    public partial class Doctors
    {
        [Inject] private IApplicationUserService applicationService { get; set; } = null!;
        private List<Doctor> doctors;

        protected override async Task OnInitializedAsync()
        {
            var entities = applicationService.GetAllAttached()
                .ToList();

            doctors = new List<Doctor>()
            {
                new Doctor
                {
                    Name = $"Dr. {entities[1].Firstname} {entities[1].Lastname}",
                    Specialty = "Pädiaterin",
                    Description =
                        "Dr. Roy ist spezialisiert auf die Behandlung von Kindern und sorgt für deren gesundes Wachstum und Entwicklung. Sie ist bekannt für ihre einfühlsame Betreuung.",
                    ImageUrl =
                        "https://img.freepik.com/fotos-kostenlos/schoene-junge-aerztin-die-kamera-im-buero-betrachtet_1301-7807.jpg",
                    RefPage = "emiliajohnson"
                },
                new Doctor
                {
                    Name = $"Dr. {entities[0].Firstname} {entities[0].Lastname}",
                    Specialty = "Kardiologe",
                    Description =
                        "Dr. Smith ist ein führender Kardiologe mit umfassender Erfahrung in der Diagnose und Behandlung von Herzkrankheiten.",
                    ImageUrl =
                        "https://media.istockphoto.com/id/177373093/photo/indian-male-doctor.jpg?s=612x612&w=0&k=20&c=5FkfKdCYERkAg65cQtdqeO_D0JMv6vrEdPw3mX1Lkfg=",
                    RefPage = "frankgarcia"
                },
                new Doctor
                {
                    Name = $"Dr. {entities[3].Firstname} {entities[3].Lastname}",
                    Specialty = "Dermatologin",
                    Description =
                        "Dr. Clarke konzentriert sich auf die Hautpflege und hilft Patienten bei einer Vielzahl von Hauterkrankungen, darunter Akne, Ekzeme und Psoriasis.",
                    ImageUrl = "https://www.collinsdictionary.com/images/full/doctor_117169531.jpg",
                    RefPage = "alicesmith"
                },
                new Doctor
                {
                    Name = $"Dr. {entities[2].Firstname} Harris",
                    Specialty = "Orthopäde",
                    Description =
                        "Harris ist spezialisiert auf die Behandlung von Erkrankungen der Knochen, Gelenke und Muskeln und hilft Patienten, sich von Verletzungen und Operationen zu erholen.",
                    ImageUrl = "https://www.teleclinic.com/wp-content/uploads/teleclinic-hero-slider-1-image-6.webp",
                    RefPage = "bobharris"
                }
            };
        }
    }

    public class Doctor
    {
        public string Name { get; set; } = null!;
        public string Specialty { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;
        public string RefPage { get; set; } = null!;
    }
}