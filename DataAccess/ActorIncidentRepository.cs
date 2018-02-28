using Dto.DtoClasses;
using Dto.Persistence;
using EntityModel.DatabaseSpecific;
using EntityModel.EntityClasses;
using EntityModel.Linq;
using Repository;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class ActorIncidentRepository : IRepository<CoreActorIncidentDto>
    {
        public ActorIncidentRepository(string connectionString)
        {
            LLBLGenConfiguration.Setup(connectionString);
        }

        public List<CoreActorIncidentDto> GetAll()
        {
            using (var adapter = new DataAccessAdapter())
            {
                var data = new LinqMetaData(adapter);

                return data.ActorIncident.ProjectToCoreActorIncidentDto().ToList();
            }
        }

        public CoreActorIncidentDto GetById(int id)
        {
            using (var adapter = new DataAccessAdapter())
            {
                var data = new LinqMetaData(adapter);

                //We need to do this extra call as per https://www.llblgen.com/Documentation/5.3/Derived%20Models/dto_llblgen.htm#example-projection-on-database-query
                var result = data.ActorIncident.Where(x => x.Id == id).ProjectToCoreActorIncidentDto().ToList();

                return result[0];
            }
        }

        public CoreActorIncidentDto Insert(CoreActorIncidentDto entity)
        {
            return InsertOrUpdate(entity);
        }

        public CoreActorIncidentDto Update(CoreActorIncidentDto entity)
        {
            return InsertOrUpdate(entity);
        }

        public void Delete(int id)
        {
            using (var adapter = new DataAccessAdapter())
            {
                var data = new LinqMetaData(adapter);

                var entity = data.Actor.Single(x => x.Id == id);

                if (entity != null)
                {
                    adapter.DeleteEntity(entity);
                }
            }
        }

        private CoreActorIncidentDto InsertOrUpdate(CoreActorIncidentDto dto)
        {
            using (var adapter = new DataAccessAdapter())
            {
                var data = new LinqMetaData(adapter);

                var entity = data.ActorIncident.FirstOrDefault(CoreActorIncidentDtoPersistence.CreatePkPredicate(dto));

                if (entity == null)
                {
                    entity = new ActorIncidentEntity();
                }

                entity.UpdateFromCoreActorIncidentDto(dto);

                adapter.SaveEntity(entity, true);

                //We need to do this extra call as per https://www.llblgen.com/Documentation/5.3/Derived%20Models/dto_llblgen.htm#example-projection-on-database-query
                var result = data.ActorIncident.Where(x => x.Id == entity.Id).ProjectToCoreActorIncidentDto().ToList();

                return result[0];
            }
        }
    }
}
