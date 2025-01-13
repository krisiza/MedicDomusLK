using MedicDomusLK.Data.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicDomusLK.ViewModels
{
    public class DoctorPatientServiceViewModel
    {
        public string DoctorId { get; set; } = null!;

        public ApplicationUser Doctor { get; set; } = null!;

        public ApplicationUser Patient { get; set; } = null!;

        public Service Service { get; set; } = null!;

        public DateTime DateStart { get; set; }

        public DateTime DateEnd { get; set; }
    }
}
