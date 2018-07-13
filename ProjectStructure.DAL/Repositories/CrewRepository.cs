using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using ProjectStructure.DAL.Models;
using ProjectStructure.DAL.Contracts;

namespace ProjectStructure.DAL.Repositories
{
    public class CrewRepository : IRepository<Crew>
    {
        private DataSource data;

        public CrewRepository(DataSource data)
        {
            this.data = data;
        }
        public List<Crew> GetAll()
        {
            return data.Crews;
        }
        public Crew Get(int id)
        {
            return data.Crews.FirstOrDefault(x => x.Id == id);
        }
        public void Create(Crew crew)
        {
            data.Crews.Add(crew);
        }
        public void Update(Crew crew)
        {
        }
        public void Delete(int id)
        {
            Crew crew = data.Crews.FirstOrDefault(x => x.Id == id);
            if (crew != null)
                data.Crews.Remove(crew);
        }
    }
}
