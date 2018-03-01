using Dto.DtoClasses;
using Microsoft.AspNetCore.Mvc;
using Repository;
using System.Linq;

namespace WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/ActorIncident")]
    public class ActorIncidentController : Controller
    {
        private readonly IRepository<CoreActorIncidentDto> repository;

        public ActorIncidentController(IRepository<CoreActorIncidentDto> repository)
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
            return Ok(repository.Get(id));
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] CoreActorIncidentDto entity)
        {
            return Ok(repository.Insert(entity));
        }

        // PUT api/values/
        [HttpPut]
        public IActionResult Put([FromBody] CoreActorIncidentDto entity)
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