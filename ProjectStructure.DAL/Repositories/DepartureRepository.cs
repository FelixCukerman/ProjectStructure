using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using ProjectStructure.DAL.Models;
using ProjectStructure.DAL.Contracts;

namespace ProjectStructure.DAL.Repositories
{
    public class DepartureRepository : IRepository<Departure>
    {
        private DataSource data;

        public DepartureRepository(DataSource data)
        {
            this.data = data;
        }
        public List<Departure> GetAll()
        {
            return data.Departures;
        }
        public Departure Get(int id)
        {
            return data.Departures.FirstOrDefault(x => x.Id == id);
        }
        public void Create(Departure departure)
        {
            data.Departures.Add(departure);
        }
        public void Update(int id, Departure departure)
        {
            var item = data.Departures.FirstOrDefault(x => x.Id == id);
            item = departure;
        }
        public void Delete(int id)
        {
            Departure departure = data.Departures.FirstOrDefault(x => x.Id == id);
            if (departure != null)
                data.Departures.Remove(departure);
        }
    }
}
