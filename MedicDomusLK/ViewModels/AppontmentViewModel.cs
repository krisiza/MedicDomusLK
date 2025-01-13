using MedicDomusLK.Data.Models;

namespace MedicDomusLK.ViewModels
{
    public class AppontmentViewModel
    {
        public int Id { get; set; }

        public ApplicationUser Doctor { get; set; } = null!;

        public string Service { get; set; } = null!;

        public DateTime DateStart { get; set; }

        public string Sector { get; set; } = null!;

        public string Img { get; set; } = null!;
    }
}
