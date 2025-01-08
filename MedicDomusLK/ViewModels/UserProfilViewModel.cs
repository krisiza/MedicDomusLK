using MedicDomusLK.Data.Models.Enums;
using MedicDomusLK.Data.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MedicDomusLK.ViewModels
{
    public class UserProfilViewModel
    {
        public string Firstname { get; set; } = null!;

        public string Lastname { get; set; } = null!;

        public string Birthdate { get; set; }

        public Gender? Gender { get; set; }

        public string PostCode { get; set; }

        public string Town { get; set; } = null!;

        public string Street { get; set; } = null!;
    }
}
