using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using ProjectStructure.BLL.DTOs;
using ProjectStructure.DAL.Models;
using ProjectStructure.DAL.Contracts;
using ProjectStructure.BLL.Contracts;

namespace ProjectStructure.BLL.Service
{
    public class DepartureService : IService<DepartureDTO>
    {
        IUnitOfWork unitOfWork;
        public DepartureService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public List<DepartureDTO> GetAll()
        {
            return Mapper.Map<List<DepartureDTO>>(unitOfWork.Departures.GetAll());
        }
        public DepartureDTO GetById(int id)
        {
            return Mapper.Map<List<DepartureDTO>>(unitOfWork.Departures.GetAll()).FirstOrDefault(x => x.Id == id);
        }
        public void Create(DepartureDTO departureDTO)
        {
            unitOfWork.Departures.Create(Mapper.Map<Departure>(departureDTO));
        }
        public void Update(int id, DepartureDTO departureDTO)
        {
            unitOfWork.Departures.Update(id, Mapper.Map<Departure>(departureDTO));
        }
        public void Delete(int id)
        {
            unitOfWork.Departures.Delete(id);
        }
    }
}
