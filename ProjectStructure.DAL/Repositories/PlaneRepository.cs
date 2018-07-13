using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using ProjectStructure.DAL.Contracts;
using ProjectStructure.DAL.Models;

namespace ProjectStructure.DAL.Repositories
{
    public class PlaneRepository : IRepository<Plane>
    {
        private DataSource data;

        public PlaneRepository(DataSource data)
        {
            this.data = data;
        }
        public List<Plane> GetAll()
        {
            return data.Planes;
        }
        public Plane Get(int id)
        {
            return data.Planes.FirstOrDefault(x => x.Id == id);
        }
        public void Create(Plane plane)
        {
            data.Planes.Add(plane);
        }
        public void Update(Plane plane)
        {
        }
        public void Delete(int id)
        {
            Plane plane = data.Planes.FirstOrDefault(x => x.Id == id);
            if (plane != null)
                data.Planes.Remove(plane);
        }
    }
}
