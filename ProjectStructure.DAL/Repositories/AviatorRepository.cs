using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using ProjectStructure.DAL.Contracts;
using ProjectStructure.DAL.Models;

namespace ProjectStructure.DAL.Repositories
{
    public class AviatorRepository : IRepository<Aviator>
    {
        private DataSource data;

        public AviatorRepository(DataSource data)
        {
            this.data = data;
        }
        public List<Aviator> GetAll()
        {
            return data.Aviators;
        }
        public Aviator Get(int id)
        {
            return data.Aviators.FirstOrDefault(x => x.Id == id);
        }
        public void Create(Aviator aviator)
        {
            data.Aviators.Add(aviator);
        }
        public void Update(Aviator aviator)
        {

        }
        public void Delete(int id)
        {
            Aviator aviator = data.Aviators.FirstOrDefault(x => x.Id == id);
            if (aviator != null)
                data.Aviators.Remove(aviator);
        }
    }
}
