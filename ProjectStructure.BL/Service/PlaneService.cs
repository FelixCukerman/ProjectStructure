using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using ProjectStructure.BLL.DTOs;
using ProjectStructure.DAL.Models;
using ProjectStructure.DAL.Contracts;
using ProjectStructure.BLL.Contracts;

namespace ProjectStructure.BLL.Service
{
    public class PlaneService : IService<PlaneDTO>
    {
        IUnitOfWork unitOfWork;
        public PlaneService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public List<PlaneDTO> GetAll()
        {
            return Mapper.Map<List<PlaneDTO>>(unitOfWork.Planes.GetAll());
        }
        public PlaneDTO GetById(int id)
        {
            return Mapper.Map<List<PlaneDTO>>(unitOfWork.Planes.GetAll()).FirstOrDefault(x => x.Id == id);
        }
        public void Create(PlaneDTO planeDTO)
        {
            unitOfWork.Planes.Create(Mapper.Map<Plane>(planeDTO));
        }
        public void Update(PlaneDTO planeDTO)
        {

        }
        public void Delete(int id)
        {
            unitOfWork.Planes.Delete(id);
        }
    }
}
