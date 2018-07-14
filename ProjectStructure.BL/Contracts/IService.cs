using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectStructure.BLL.Contracts
{
    public interface IService<T> where T: class
    {
        List<T> GetAll();
        T GetById(int id);
        void Create(T t);
        void Update(int id, T t);
        void Delete(int id);
    }
}
