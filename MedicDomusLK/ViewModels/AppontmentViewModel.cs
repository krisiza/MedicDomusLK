﻿using MedicDomusLK.Data.Models;

namespace MedicDomusLK.ViewModels
{
    public class AppontmentViewModel
    {
        public ApplicationUser? Doctor { get; set; }

        public ApplicationUser? Patient { get; set; }

        public Service Service { get; set; } = null!;

        public DateTime DateStart { get; set; }

        public string Sector { get; set; } = null!;

        public string Img { get; set; } = null!;
    }
}
