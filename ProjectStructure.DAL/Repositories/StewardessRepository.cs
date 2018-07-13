using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using ProjectStructure.DAL.Models;
using ProjectStructure.DAL.Contracts;

namespace ProjectStructure.DAL.Repositories
{
    public class StewardessRepository : IRepository<Stewardess>
    {
        private DataSource data;

        public StewardessRepository(DataSource data)
        {
            this.data = data;
        }
        public List<Stewardess> GetAll()
        {
            return data.Stewardesses;
        }
        public Stewardess Get(int id)
        {
            return data.Stewardesses.FirstOrDefault(x => x.Id == id);
        }
        public void Create(Stewardess stewardess)
        {
            data.Stewardesses.Add(stewardess);
        }
        public void Update(Stewardess stewardess)
        {

        }
        public void Delete(int id)
        {
            Stewardess stewardess = data.Stewardesses.FirstOrDefault(x => x.Id == id);
            if (stewardess != null)
                data.Stewardesses.Remove(stewardess);
        }
    }
}
