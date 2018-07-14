using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using ProjectStructure.DAL.Contracts;
using ProjectStructure.DAL.Models;

namespace ProjectStructure.DAL.Repositories
{
    public class TicketRepository : IRepository<Ticket>
    {
        private DataSource data;

        public TicketRepository(DataSource data)
        {
            this.data = data;
        }
        public List<Ticket> GetAll()
        {
            return data.Tickets;
        }
        public Ticket Get(int id)
        {
            return data.Tickets.FirstOrDefault(x => x.Id == id);
        }
        public void Create(Ticket ticket)
        {
            data.Tickets.Add(ticket);
        }
        public void Update(int id, Ticket ticket)
        {
            var item = data.Tickets.FirstOrDefault(x => x.Id == id);
            item = ticket;
        }
        public void Delete(int id)
        {
            Ticket ticket = data.Tickets.FirstOrDefault(x => x.Id == id);
            if (ticket != null)
                data.Tickets.Remove(ticket);
        }
    }
}
