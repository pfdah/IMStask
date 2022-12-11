using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ims_task.Model
{
    public class TariffDetails
    {
        [Key]
        [Required]
        public int tariffId { get; set; }
        [Required]
        public int startUnit { get; set; }
        [Required]
        public int endUnit { get; set; }
        [Required]
        public decimal energyRate { get; set; }
        [Required]
        public decimal serviceCharge { get; set; }
    }
    public class TariffMaster
    {
        [Required]
        [Key]
        public int tariffId { get; set; }
        [Required]
        public int rebateDays { get; set; }
        [Required]
        public decimal rebateRate { get; set; }
        [Required]
        public int penaltyDays { get; set; }
        [Required]
        public decimal penaltyRate { get; set; }
    }
}
