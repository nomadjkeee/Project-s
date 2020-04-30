using System.ComponentModel.DataAnnotations;

namespace VidlyAuth.Models
{

    public class MemberShip
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string MemberShipType { get; set; }
        [Required]
        public short PercentCount { get; set; }

    }
}