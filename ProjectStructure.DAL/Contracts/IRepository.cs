using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectStructure.DAL.Contracts
{
    public interface IRepository<T> where T: class
    {
        List<T> GetAll();
        T Get(int id);
        void Create(T item);
        void Update(T item);
        void Delete(int id);
    }
}
