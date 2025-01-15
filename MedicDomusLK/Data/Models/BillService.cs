using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicDomusLK.Data.Models
{
    [PrimaryKey(nameof(BillId), nameof(ServiceId))]
    public class BillService
    {
        public string BillId { get; set; }

        [ForeignKey(nameof(BillId))]
        public Bill Bill { get; set; } = null!;

        public int ServiceId { get; set; }

        [ForeignKey(nameof(ServiceId))]
        public Service Service { get; set; } = null!;
    }
}
