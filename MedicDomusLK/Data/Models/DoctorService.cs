using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicDomusLK.Data.Models
{
    [PrimaryKey(nameof(Id), nameof(DoctorId), nameof(PatientId), nameof(Date))]
    public class DoctorService
    {
        public int Id { get; set; }

        public int DoctorId { get; set; }

        [ForeignKey(nameof(DoctorId))]
        public ApplicationUser Doctor { get; set; } = null!;

        public int PatientId { get; set; }

        [ForeignKey(nameof(PatientId))]
        public ApplicationUser Patient { get; set; } = null!;

        public DateTime Date { get; set; }
    }
}
