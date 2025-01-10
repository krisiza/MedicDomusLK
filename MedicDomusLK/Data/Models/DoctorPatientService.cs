using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicDomusLK.Data.Models
{
    [PrimaryKey(nameof(DoctorId), nameof(PatientId), nameof(ServiceId), nameof(DateStart))]
    public class DoctorPatientService
    {
        public string DoctorId { get; set; } = null!;

        [ForeignKey(nameof(DoctorId))]
        public ApplicationUser Doctor { get; set; } = null!;

        public string PatientId { get; set; } = null!;

        [ForeignKey(nameof(PatientId))]
        public ApplicationUser Patient { get; set; } = null!;

        public int ServiceId { get; set; }

        [ForeignKey(nameof(ServiceId))]
        public Service Service { get; set; } = null!;

        public DateTime DateStart { get; set; }

        public DateTime DateEnd { get; set; }
    }
}
