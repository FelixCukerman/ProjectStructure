using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using ProjectStructure.DAL.Contracts;
using ProjectStructure.DAL.Models;

namespace ProjectStructure.DAL.Repositories
{
    public class FlightRepository : IRepository<Flight>
    {
        private DataSource data;

        public FlightRepository(DataSource data)
        {
            this.data = data;
        }
        public List<Flight> GetAll()
        {
            return data.Flights;
        }
        public Flight Get(int id)
        {
            return data.Flights.FirstOrDefault(x => x.Number == id);
        }
        public void Create(Flight flight)
        {
            data.Flights.Add(flight);
        }
        public void Update(Flight flight)
        {
        }
        public void Delete(int id)
        {
            Flight flight = data.Flights.FirstOrDefault(x => x.Number == id);
            if (flight != null)
                data.Flights.Remove(flight);
        }
    }
}
