using Dto.DtoClasses;
using EntityModel.DatabaseSpecific;
using EntityModel.EntityClasses;
using EntityModel.Linq;
using EntityModel.TypedListClasses;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Repository;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;

namespace WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]/[action]")]
    public class SpecificItemController : Controller
    {
        private readonly IRepository<SpecificItemDto> restRepository;
        private readonly ITypedListRepository<SpecificItemTypedListRow> inflatedRepository;
        private readonly IFullItemRepository<SpecificItemEntity> fullItemRepository;
        private readonly IRepository<ActorPersonDto> actorRepository;

        public SpecificItemController(IRepository<SpecificItemDto> restRepository, ITypedListRepository<SpecificItemTypedListRow> inflatedRepository, IFullItemRepository<SpecificItemEntity> fullItemRepository, IRepository<ActorPersonDto> actorRepository)
        {
            this.restRepository = restRepository;
            this.inflatedRepository = inflatedRepository;
            this.fullItemRepository = fullItemRepository;
            this.actorRepository = actorRepository;
        }

        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(restRepository.GetAll().ToList());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult GetInflated(int id)
        {
            var dto = restRepository.Get(id);
            dynamic expandoObject = new ExpandoObject();

            expandoObject = ConvertToExpando(dto);

            foreach (var incident in dto.Incidents)
            {
                List<dynamic> actors = new List<dynamic>();

                foreach (var actorIncident in incident.ActorIncidents)
                {
                    var actor = actorRepository.Get(actorIncident.ActorId);
                    actors.Add(ConvertToExpando(actor));
                }

                expandoObject.Incidents.Actors = new ExpandoObject();
                expandoObject.Incidents.Actors = actors;
            }

            return Ok(expandoObject);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(restRepository.Get(id));
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] SpecificItemDto entity)
        {
            return Ok(restRepository.Insert(entity));
        }

        // PUT api/values/
        [HttpPut]
        public IActionResult Put([FromBody] SpecificItemDto entity)
        {
            return Ok(restRepository.Update(entity));
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            restRepository.Delete(id);
        }

        private ExpandoObject ConvertToExpando(object input)
        {
            var inputAsJson = JsonConvert.SerializeObject(input);

            var converter = new ExpandoObjectConverter();
            return JsonConvert.DeserializeObject<ExpandoObject>(inputAsJson, converter);
        }
    }
}
