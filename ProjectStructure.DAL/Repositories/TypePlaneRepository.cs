using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using ProjectStructure.DAL.Contracts;
using ProjectStructure.DAL.Models;

namespace ProjectStructure.DAL.Repositories
{
    public class TypePlaneRepository : IRepository<TypePlane>
    {
        private DataSource data;

        public TypePlaneRepository(DataSource data)
        {
            this.data = data;
        }
        public List<TypePlane> GetAll()
        {
            return data.TypePlanes;
        }
        public TypePlane Get(int id)
        {
            return data.TypePlanes.FirstOrDefault(x => x.Id == id);
        }
        public void Create(TypePlane typePlane)
        {
            data.TypePlanes.Add(typePlane);
        }
        public void Update(TypePlane typePlane)
        {
        }
        public void Delete(int id)
        {
            TypePlane typePlane = data.TypePlanes.FirstOrDefault(x => x.Id == id);
            if (typePlane != null)
                data.TypePlanes.Remove(typePlane);
        }
    }
}
