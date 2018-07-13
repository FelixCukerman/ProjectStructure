using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;

namespace ProjectStructure.DAL.Contracts
{
    public interface IUnitOfWork
    {
        int SaveChanges();
    }
}
