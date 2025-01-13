using System.ComponentModel.DataAnnotations;

namespace MedicDomusLK.ViewModels
{
    public class DoctorViewModel
    {
        public string Firstname { get; set; } = null!;

        public string Lastname { get; set; } = null!;

        public DateTime Birthdate { get; set; }
    }
}
