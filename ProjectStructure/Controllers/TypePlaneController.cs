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
    [Route("api/TypePlane")]
    public class TypePlaneController : Controller
    {
        private TypePlaneService typePlaneService;
        public TypePlaneController(TypePlaneService typePlaneService)
        {
            this.typePlaneService = typePlaneService;
        }
        // GET: api/TypePlane
        [HttpGet]
        public List<TypePlaneDTO> Get()
        {
            return typePlaneService.GetAll();
        }

        // GET: api/TypePlane/5
        [HttpGet("{id}")]
        public TypePlaneDTO Get(int id)
        {
            return typePlaneService.GetAll().FirstOrDefault(x => x.Id == id);
        }
        
        // POST: api/TypePlane
        [HttpPost]
        public void Post([FromBody]TypePlaneDTO value)
        {
            typePlaneService.Create(value);
        }
        
        // PUT: api/TypePlane/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]TypePlaneDTO value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            typePlaneService.Delete(id);
        }
    }
}
