using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;
using ProjectStructure.DAL.Contracts;
using ProjectStructure.DAL.Repositories;
using ProjectStructure.DAL.Models;

namespace ProjectStructure.DAL
{
    class UnitOfWork : IUnitOfWork
    {
        private DataSource data = new DataSource();

        private AviatorRepository aviatorRepository;
        private CrewRepository crewRepository;
        private DepartureRepository departureRepository;
        private FlightRepository flightRepository;
        private PlaneRepository planeRepository;
        private StewardessRepository stewardessRepository;
        private TicketRepository ticketRepository;
        private TypePlaneRepository typePlaneRepository;

        public IRepository<Aviator> Aviators
        {
            get
            {
                if (aviatorRepository == null)
                    aviatorRepository = new AviatorRepository(data);
                return aviatorRepository;
            }
        }
        public  IRepository<Crew> Crews
        {
            get
            {
                if (crewRepository == null)
                    crewRepository = new CrewRepository(data);
                return crewRepository;
            }
        }
        public IRepository<Departure> Departures
        {
            get
            {
                if (departureRepository == null)
                    departureRepository = new DepartureRepository(data);
                return departureRepository;
            }
        }
        public IRepository<Flight> Flights
        {
            get
            {
                if (flightRepository == null)
                    flightRepository = new FlightRepository(data);
                return flightRepository;
            }
        }
        public IRepository<Plane> Planes
        {
            get
            {
                if (planeRepository == null)
                    planeRepository = new PlaneRepository(data);
                return planeRepository;
            }
        }
        public IRepository<Stewardess> Stewardesses
        {
            get
            {
                if (stewardessRepository == null)
                    stewardessRepository = new StewardessRepository(data);
                return stewardessRepository;
            }
        }
        public IRepository<Ticket> Tickets
        {
            get
            {
                if (ticketRepository == null)
                    ticketRepository = new TicketRepository(data);
                return ticketRepository;
            }
        }
        public IRepository<TypePlane> TypesPlane
        {
            get
            {
                if (typePlaneRepository == null)
                    typePlaneRepository = new TypePlaneRepository(data);
                return typePlaneRepository;
            }
        }

        //TODO разобраться что эта штуковина должна делать
        public int SaveChanges()
        {
            return 0;
        }
    }
}
