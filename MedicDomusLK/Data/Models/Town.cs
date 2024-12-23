using System.ComponentModel.DataAnnotations;
using static MedicDomusLK.DataConstants.Validations.HometownConst;


namespace MedicDomusLK.Data.Models
{
    public class Town
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(PlzSize)]
        public string PLZ { get; set; } = null!;

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;
    }
}
