using System.ComponentModel.DataAnnotations;

namespace ProjectStructure.BLL.DTOs
{
    public class TicketDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        [Range(100, 9999)]
        public int FlightNumber { get; set; }
    }
}
