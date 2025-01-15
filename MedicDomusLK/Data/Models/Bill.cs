using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicDomusLK.Data.Models
{
    public class Bill
    {
        [Key]
        public string Id { get; set; }

        public DateTime Date { get; set; }

        public string DoctorId { get; set; }

        [ForeignKey(nameof(DoctorId))]
        public ApplicationUser Doctor { get; set; }

        public string PatientId { get; set; }

        [ForeignKey(nameof(PatientId))]
        public ApplicationUser Patient { get; set; }

        [Range(1, int.MaxValue)]
        public decimal Price { get; set; }

        public  bool Paid { get; set; } = false;

        public List<Service> Services { get; set; } = new List<Service>();
    }
}
