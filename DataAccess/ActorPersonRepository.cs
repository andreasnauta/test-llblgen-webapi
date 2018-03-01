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
    public class ActorPersonRepository : IRepository<ActorPersonDto>
    {
        public ActorPersonRepository(string connectionString)
        {
            LLBLGenConfiguration.Setup(connectionString);
        }

        public List<ActorPersonDto> GetAll()
        {
            using (var adapter = new DataAccessAdapter())
            {
                var data = new LinqMetaData(adapter);

                return data.Person.ProjectToActorPersonDto().ToList();
            }
        }

        public ActorPersonDto Get(int id)
        {
            using (var adapter = new DataAccessAdapter())
            {
                var data = new LinqMetaData(adapter);

                //We need to do this extra call as per https://www.llblgen.com/Documentation/5.3/Derived%20Models/dto_llblgen.htm#example-projection-on-database-query
                var result = data.Person.Where(x => x.Id == id).ProjectToActorPersonDto().ToList();

                return result[0];
            }
        }

        public ActorPersonDto Insert(ActorPersonDto entity)
        {
            return InsertOrUpdate(entity);
        }

        public ActorPersonDto Update(ActorPersonDto entity)
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

        private ActorPersonDto InsertOrUpdate(ActorPersonDto dto)
        {
            using (var adapter = new DataAccessAdapter())
            {
                var data = new LinqMetaData(adapter);

                var entity = data.Person.FirstOrDefault(ActorPersonDtoPersistence.CreatePkPredicate(dto));

                if (entity == null)
                {
                    entity = new PersonEntity();
                }

                entity.UpdateFromActorPersonDto(dto);

                adapter.SaveEntity(entity, true);

                //We need to do this extra call as per https://www.llblgen.com/Documentation/5.3/Derived%20Models/dto_llblgen.htm#example-projection-on-database-query
                var result = data.Person.Where(x => x.Id == entity.Id).ProjectToActorPersonDto().ToList();

                return result[0];
            }
        }
    }
}
