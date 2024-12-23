using System.ComponentModel.DataAnnotations;
using static MedicDomusLK.DataConstants.Validations.ServiceConst;

namespace MedicDomusLK.Data.Models
{
    public class Service
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        [Range(0, PriceMax)]
        public decimal Price { get; set; }
    }
}
