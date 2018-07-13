using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectStructure.DAL.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public int FlightNumber { get; set; }
    }
}
