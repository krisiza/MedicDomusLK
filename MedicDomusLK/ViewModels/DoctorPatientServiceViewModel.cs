using Itenso.TimePeriod;
using MedicDomusLK.Data.Models;

namespace MedicDomusLK.ViewModels
{
    public class DoctorPatientServiceViewModel
    {
        public ApplicationUser Doctor { get; set; } = null!;

        public ApplicationUser Patient { get; set; } = null!;

        public Service Service { get; set; } = null!;

        public DateTime DateStart { get; set; }

        public DateTime DateEnd { get; set; }

        public TimeRange TimeRange { get; set; } = new TimeRange();
    }
}
