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
    [Route("api/Departure")]
    public class DepartureController : Controller
    {
        private DepartureService departureService;
        public DepartureController(DepartureService departureService)
        {
            this.departureService = departureService;
        }
        // GET: api/Departure
        [HttpGet]
        public List<DepartureDTO> Get()
        {
            return departureService.GetAll();
        }

        // GET: api/Departure/5
        [HttpGet("{id}", Name = "Get")]
        public DepartureDTO Get(int id)
        {
            return departureService.GetAll().FirstOrDefault(x => x.Id == id);
        }
        
        // POST: api/Departure
        [HttpPost]
        public void Post([FromBody]DepartureDTO value)
        {
            departureService.Create(value);
        }
        
        // PUT: api/Departure/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]DepartureDTO value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            departureService.Delete(id);
        }
    }
}
