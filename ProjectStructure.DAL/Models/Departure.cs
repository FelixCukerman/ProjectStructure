﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectStructure.DAL.Models
{
    public class Departure
    {
        public int Id { get; set; }
        public int FlightNumber { get; set; }
        public int TimeOfDeparture { get; set; }
        public int CrewId { get; set; }
        public int PlaneId { get; set; }
    }
}
