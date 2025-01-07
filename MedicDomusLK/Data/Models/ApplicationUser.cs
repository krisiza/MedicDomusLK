using MedicDomusLK.Data.Models.Enums;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static MedicDomusLK.DataConstants.Validations.ApplicationUserConst;

namespace MedicDomusLK.Data.Models
{
    public class ApplicationUser : IdentityUser
    {

        [Required]
        [MaxLength(FirstNameMaxLength)]
        public string Firstname { get; set; } = null!;

        [Required]
        [MaxLength(LastNameMaxLength)]
        public string Lastname { get; set; } = null!;

        [Required]
        public DateTime Birthdate { get; set; }

        public Gender? Gender { get; set; }

        public int TownId { get; set; }

        [ForeignKey(nameof(TownId))]
        public Town Town { get; set; } = null!;

        [Required]
        [MaxLength(StreetMaxLength)]
        public string Street { get; set; } = null!;
    }
}
