using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using ProjectStructure.BLL.DTOs;
using ProjectStructure.DAL.Models;
using ProjectStructure.DAL.Contracts;

namespace ProjectStructure.BLL.Service
{
    public class StewardessService
    {
        IUnitOfWork unitOfWork;
        public StewardessService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public List<StewardessDTO> GetAll()
        {
            return Mapper.Map<List<StewardessDTO>>(unitOfWork.Stewardesses.GetAll());
        }
        public StewardessDTO GetById(int id)
        {
            return Mapper.Map<List<StewardessDTO>>(unitOfWork.Stewardesses.GetAll()).FirstOrDefault(x => x.Id == id);
        }
        public void Create(StewardessDTO stewardessDTO)
        {
            unitOfWork.Stewardesses.Create(Mapper.Map<Stewardess>(stewardessDTO));
        }
        public void Update(StewardessDTO stewardessDTO)
        {

        }
        public void Delete(int id)
        {
            unitOfWork.Stewardesses.Delete(id);
        }
    }
}
