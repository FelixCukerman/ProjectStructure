using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;
using ProjectStructure.DAL.Contracts;
using ProjectStructure.DAL.Repositories;

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

        public AviatorRepository Aviators
        {
            get
            {
                if (aviatorRepository == null)
                    aviatorRepository = new AviatorRepository(data);
                return aviatorRepository;
            }
        }
        public CrewRepository Crews
        {
            get
            {
                if (crewRepository == null)
                    crewRepository = new CrewRepository(data);
                return crewRepository;
            }
        }
        public DepartureRepository Departures
        {
            get
            {
                if (departureRepository == null)
                    departureRepository = new DepartureRepository(data);
                return departureRepository;
            }
        }
        public FlightRepository Flights
        {
            get
            {
                if (flightRepository == null)
                    flightRepository = new FlightRepository(data);
                return flightRepository;
            }
        }
        public PlaneRepository Planes
        {
            get
            {
                if (planeRepository == null)
                    planeRepository = new PlaneRepository(data);
                return planeRepository;
            }
        }
        public StewardessRepository Stewardesses
        {
            get
            {
                if (stewardessRepository == null)
                    stewardessRepository = new StewardessRepository(data);
                return stewardessRepository;
            }
        }
        public TicketRepository Tickets
        {
            get
            {
                if (ticketRepository == null)
                    ticketRepository = new TicketRepository(data);
                return ticketRepository;
            }
        }
        public TypePlaneRepository TypesPlane
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
