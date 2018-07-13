using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using ProjectStructure.DAL.Models;

namespace ProjectStructure.DAL
{
    public class DataSource
    {
        public List<Aviator> Aviators { get; set; }
        public List<Crew> Crews { get; set; }
        public List<Departure> Departures { get; set; }
        public List<Flight> Flights { get; set; }
        public List<Plane> Planes { get; set; }
        public List<Stewardess> Stewardesses { get; set; }
        public List<Ticket> Tickets { get; set; }
        public List<TypePlane> TypePlanes { get; set; }

        public DataSource()
        {
            Aviators = new List<Aviator>
            {
                new Aviator { Id = 1, Name = "Naruto", Surname = "Uzumaki", DateOfBirthday = DateTime.Now, Experience = 3 },
                new Aviator { Id = 2, Name = "Kakasi", Surname = "Hatake", DateOfBirthday = DateTime.Now, Experience = 2 },
                new Aviator { Id = 3, Name = "Obito", Surname = "Uchiha", DateOfBirthday = DateTime.Now, Experience = 1 }
            };

            Crews = new List<Crew>
            {
                new Crew { Id = 1, aviator = Aviators.FirstOrDefault(x => x.Id == 1), stewardesses = Stewardesses},
                new Crew { Id = 2, aviator = Aviators.FirstOrDefault(x => x.Id == 2), stewardesses = Stewardesses},
                new Crew { Id = 3, aviator = Aviators.FirstOrDefault(x => x.Id == 2), stewardesses = Stewardesses}
            };

            Departures = new List<Departure>
            {
                new Departure { Id = 1, CrewId = 1, FlightNumber = 111, PlaneId = 1, TimeOfDeparture = 1 },
                new Departure { Id = 2, CrewId = 2, FlightNumber = 222, PlaneId = 2, TimeOfDeparture = 2 },
                new Departure { Id = 3, CrewId = 3, FlightNumber = 333, PlaneId = 3, TimeOfDeparture = 3 }
            };

            Flights = new List<Flight>
            {
                new Flight { Number = 1, ArrivalTime = DateTime.Now, Destination = "Kiev", TicketId = 1, PointOfDeparture = "Kharkiv", TimeOfDeparture = DateTime.Now},
                new Flight { Number = 2, ArrivalTime = DateTime.Now, Destination = "Kiev", TicketId = 2, PointOfDeparture = "Kharkiv", TimeOfDeparture = DateTime.Now},
                new Flight { Number = 3, ArrivalTime = DateTime.Now, Destination = "Kiev", TicketId = 3, PointOfDeparture = "Kharkiv", TimeOfDeparture = DateTime.Now},
            };

            Planes = new List<Plane>
            {
                new Plane { Id = 1, Name = "Combo", ReleaseDate = DateTime.Now, TimeSpan = 34, Type = "Motoplane"},
                new Plane { Id = 2, Name = "Limbo", ReleaseDate = DateTime.Now, TimeSpan = 43, Type = "Caroplane"},
                new Plane { Id = 3, Name = "Rambo", ReleaseDate = DateTime.Now, TimeSpan = 343, Type = "Aeroplane"},
            };

            Stewardesses = new List<Stewardess>
            {
                new Stewardess { Id = 1, Name = "one", Surname = "#", DateOfBirthday = DateTime.Now},
                new Stewardess { Id = 2, Name = "two", Surname = "#", DateOfBirthday = DateTime.Now},
                new Stewardess { Id = 3, Name = "three", Surname = "#", DateOfBirthday = DateTime.Now}
            };

            Tickets = new List<Ticket>
            {
                new Ticket { Id = 1, Price = 666, FlightNumber = 111 },
                new Ticket { Id = 2, Price = 666, FlightNumber = 222 },
                new Ticket { Id = 3, Price = 666, FlightNumber = 333 }
            };

            TypePlanes = new List<TypePlane>
            {
                new TypePlane { Id = 1, CountOfSeats = 13, CarryingCapacity = 666, ModelOfPlane = "HELLo world!"},
                new TypePlane { Id = 2, CountOfSeats = 31, CarryingCapacity = 666, ModelOfPlane = "HELLo world!"},
                new TypePlane { Id = 3, CountOfSeats = 131, CarryingCapacity = 333, ModelOfPlane = "HELLo world!"}
            };
        }
    }
}
