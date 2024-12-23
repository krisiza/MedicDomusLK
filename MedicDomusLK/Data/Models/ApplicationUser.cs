using MedicDomusLK.Data.Models.Enums;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
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
        private string Lastname { get; set; } = null!;

        [Required]
        public DateTime Birthdate { get; set; }

        public Gender? Gender { get; set; }

        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(StreetMaxLength)]
        public string Street { get; set; } = null!;
    }
}
