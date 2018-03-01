using Dto.DtoClasses;
using EntityModel.DatabaseSpecific;
using EntityModel.Linq;
using EntityModel.TypedListClasses;
using Microsoft.AspNetCore.Mvc;
using Repository;
using System.Linq;

namespace WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]/[action]")]
    public class SpecificItemController : Controller
    {
        private readonly IRepository<SpecificItemDto> restrepository;
        private readonly ITypedListRepository<SpecificItemTypedListRow> inflatedrepository;

        public SpecificItemController(IRepository<SpecificItemDto> restrepository, ITypedListRepository<SpecificItemTypedListRow> inflatedrepository)
        {
            this.restrepository = restrepository;
            this.inflatedrepository = inflatedrepository;
        }

        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(restrepository.GetAll().ToList());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult GetInflated(int id)
        {
            return Ok(inflatedrepository.GetInflated(id));
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(restrepository.Get(id));
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] SpecificItemDto entity)
        {
            return Ok(restrepository.Insert(entity));
        }

        // PUT api/values/
        [HttpPut]
        public IActionResult Put([FromBody] SpecificItemDto entity)
        {
            return Ok(restrepository.Update(entity));
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            restrepository.Delete(id);
        }
    }
}
