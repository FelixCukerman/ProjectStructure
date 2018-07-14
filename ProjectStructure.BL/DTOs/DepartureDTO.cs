using System.ComponentModel.DataAnnotations;

namespace ProjectStructure.BLL.DTOs
{
    public class DepartureDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [Range(100, 9999)]
        public int FlightNumber { get; set; }
        [Required]
        public int TimeOfDeparture { get; set; }
        [Required]
        public int CrewId { get; set; }
        [Required]
        public int PlaneId { get; set; }
    }
}
