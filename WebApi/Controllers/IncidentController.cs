using Dto.DtoClasses;
using Microsoft.AspNetCore.Mvc;
using Repository;
using System.Linq;

namespace WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Incident")]
    public class IncidentController : Controller
    {
        private readonly IRepository<CoreIncidentDto> repository;

        public IncidentController(IRepository<CoreIncidentDto> repository)
        {
            this.repository = repository;
        }

        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(repository.GetAll().ToList());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(repository.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] CoreIncidentDto entity)
        {
            return Ok(repository.Insert(entity));
        }

        // PUT api/values/
        [HttpPut]
        public IActionResult Put([FromBody] CoreIncidentDto entity)
        {
            return Ok(repository.Update(entity));
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            repository.Delete(id);
        }
    }
}