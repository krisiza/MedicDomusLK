using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicDomusLK.Data.Models
{
    [PrimaryKey(nameof(DoctorId), nameof(PatientId), nameof(ServiceId))]
    public class DoctorPatientService
    {
        public string DoctorId { get; set; }

        [ForeignKey(nameof(DoctorId))]
        public ApplicationUser Doctor { get; set; }

        public string PatientId { get; set; }

        [ForeignKey(nameof(PatientId))]
        public ApplicationUser Patient { get; set; }

        public int ServiceId { get; set; }

        [ForeignKey(nameof(ServiceId))]
        public Service Service { get; set; }
    }
}
