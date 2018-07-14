using System.ComponentModel.DataAnnotations;

namespace ProjectStructure.BLL.DTOs
{
    public class TypePlaneDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 1)]
        public string ModelOfPlane { get; set; }
        [Required]
        public int CountOfSeats { get; set; }
        [Required]
        public int CarryingCapacity { get; set; }
    }
}
