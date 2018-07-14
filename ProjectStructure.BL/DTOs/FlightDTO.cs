using System;
using System.ComponentModel.DataAnnotations;

namespace ProjectStructure.BLL.DTOs
{
    public class FlightDTO
    {
        [Required]
        [Range(100, 9999)]
        public int Number { get; set; }
        [Required]
        public string PointOfDeparture { get; set; }
        [Required]
        public DateTime TimeOfDeparture { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Destination { get; set; }
        [Required]
        public DateTime ArrivalTime { get; set; }
        [Required]
        public int TicketId { get; set; }
    }
}
