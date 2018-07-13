using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using ProjectStructure.BLL.DTOs;
using ProjectStructure.DAL.Models;
using ProjectStructure.DAL.Contracts;
using ProjectStructure.BLL.Contracts;

namespace ProjectStructure.BLL.Service
{
    public class FlightService : IService<FlightDTO>
    {
        IUnitOfWork unitOfWork;
        public FlightService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public List<FlightDTO> GetAll()
        {
            return Mapper.Map<List<FlightDTO>>(unitOfWork.Departures.GetAll());
        }
        public FlightDTO GetById(int id)
        {
            return Mapper.Map<List<FlightDTO>>(unitOfWork.Departures.GetAll()).FirstOrDefault(x => x.Number == id);
        }
        public void Create(FlightDTO flightDTO)
        {
            unitOfWork.Flights.Create(Mapper.Map<Flight>(flightDTO));
        }
        public void Update(FlightDTO flightDTO)
        {

        }
        public void Delete(int id)
        {
            unitOfWork.Flights.Delete(id);
        }
    }
}
