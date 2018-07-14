using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectStructure.BLL.Service;
using ProjectStructure.BLL.DTOs;

namespace ProjectStructure.Controllers
{
    [Produces("application/json")]
    [Route("api/Flight")]
    public class FlightController : Controller
    {
        private FlightService flightService;
        public FlightController(FlightService flightService)
        {
            this.flightService = flightService;
        }
        // GET: api/Flight
        [HttpGet]
        public List<FlightDTO> Get()
        {
            return flightService.GetAll();
        }

        // GET: api/Flight/5
        [HttpGet("{id}")]
        public FlightDTO Get(int id)
        {
            return flightService.GetAll().FirstOrDefault(x => x.Number == id);
        }
        
        // POST: api/Flight
        [HttpPost]
        public void Post([FromBody]FlightDTO value)
        {
            flightService.Create(value);
        }
        
        // PUT: api/Flight/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]FlightDTO value)
        {
            flightService.Update(id, value);
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            flightService.Delete(id);
        }
    }
}
