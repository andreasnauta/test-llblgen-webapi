using Dto.DtoClasses;
using Microsoft.AspNetCore.Mvc;
using Repository;
using System.Linq;

namespace WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Person")]
    public class PersonController : Controller
    {
        private readonly IRepository<ActorPersonDto> repository;

        public PersonController(IRepository<ActorPersonDto> repository)
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
        public IActionResult Post([FromBody] ActorPersonDto entity)
        {
            return Ok(repository.Insert(entity));
        }

        // PUT api/values/
        [HttpPut]
        public IActionResult Put([FromBody] ActorPersonDto entity)
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