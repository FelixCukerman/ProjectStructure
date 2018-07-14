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
    [Route("api/Aviators")]
    public class AviatorsController : Controller
    {
        private AviatorService aviatorService { get; set; }
        public AviatorsController(AviatorService aviatorService)
        {
            this.aviatorService = aviatorService;
        }

        // GET: api/Aviators
        [HttpGet]
        public List<AviatorDTO> Get()
        {
            return aviatorService.GetAll();
        }

        // GET: api/Aviators/5
        [HttpGet("{id}")]
        public AviatorDTO Get(int id)
        {
            return aviatorService.GetAll().FirstOrDefault(x => x.Id == id);
        }
        
        // POST: api/Aviators
        [HttpPost]
        public void Post([FromBody]AviatorDTO value)
        {
            aviatorService.Create(value);
        }
        
        // PUT: api/Aviators/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]AviatorDTO value)
        {
            aviatorService.Update(id, value);
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            aviatorService.Delete(id);
        }
    }
}