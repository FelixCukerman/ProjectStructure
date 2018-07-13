using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectStructure.DAL.Models
{
    public class Flight
    {
        public int Number { get; set; }
        public string PointOfDeparture { get; set; }
        public DateTime TimeOfDeparture { get; set; }
        public string Destination { get; set; }
        public DateTime ArrivalTime { get; set; }
        public int TicketId { get; set; }
    }
}
