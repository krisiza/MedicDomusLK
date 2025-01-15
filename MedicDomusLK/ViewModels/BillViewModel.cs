using MedicDomusLK.Data.Models;

namespace MedicDomusLK.ViewModels
{
    public class BillViewModel
    {
        public string Id { get; set; } = null!;

        public DateTime Date { get; set; }

        public ApplicationUser Doctor { get; set; } = null!;

        public ApplicationUser Patient { get; set; } = null!;

        public decimal Price { get; set; }

        public bool Paid { get; set; } = false;

        public List<Service> Services { get; set; } = new List<Service>();
    }
}
