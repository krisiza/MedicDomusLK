using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicDomusLK.Data.Models
{
    public class DoctorInfo
    {
        [Key]
        public int Id { get; set; }
        public string DoctorId { get; set; } = null!;

        [ForeignKey(nameof(DoctorId))]
        public ApplicationUser Doctor { get; set; } = null!;

        public string Description { get; set; } = null!;

        public double Score { get; set; }

        public string Sector { get; set; } = null!;

        public int ExperienceYear { get; set; }

        public string Img { get; set; } = null!;
    }
}
