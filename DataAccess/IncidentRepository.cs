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
    public class IncidentRepository : IRepository<CoreIncidentDto>
    {
        public IncidentRepository(string connectionString)
        {
            LLBLGenConfiguration.Setup(connectionString);
        }

        public List<CoreIncidentDto> GetAll()
        {
            using (var adapter = new DataAccessAdapter())
            {
                var data = new LinqMetaData(adapter);

                return data.Incident.ProjectToCoreIncidentDto().ToList();
            }
        }

        public CoreIncidentDto GetById(int id)
        {
            using (var adapter = new DataAccessAdapter())
            {
                var data = new LinqMetaData(adapter);

                //We need to do this extra call as per https://www.llblgen.com/Documentation/5.3/Derived%20Models/dto_llblgen.htm#example-projection-on-database-query
                var result = data.Incident.Where(x => x.Id == id).ProjectToCoreIncidentDto().ToList();

                return result[0];
            }
        }

        public CoreIncidentDto Insert(CoreIncidentDto entity)
        {
            return InsertOrUpdate(entity);
        }

        public CoreIncidentDto Update(CoreIncidentDto entity)
        {
            return InsertOrUpdate(entity);
        }

        public void Delete(int id)
        {
            using (var adapter = new DataAccessAdapter())
            {
                var data = new LinqMetaData(adapter);

                var entity = data.Incident.Single(x => x.Id == id);

                if (entity != null)
                {
                    adapter.DeleteEntity(entity);
                }
            }
        }

        private CoreIncidentDto InsertOrUpdate(CoreIncidentDto dto)
        {
            using (var adapter = new DataAccessAdapter())
            {
                var data = new LinqMetaData(adapter);

                var entity = data.Incident.FirstOrDefault(CoreIncidentDtoPersistence.CreatePkPredicate(dto));

                if (entity == null)
                {
                    entity = new IncidentEntity();
                }

                entity.UpdateFromCoreIncidentDto(dto);

                adapter.SaveEntity(entity, true);

                //We need to do this extra call as per https://www.llblgen.com/Documentation/5.3/Derived%20Models/dto_llblgen.htm#example-projection-on-database-query
                var result = data.Incident.Where(x => x.Id == entity.Id).ProjectToCoreIncidentDto().ToList();

                return result[0];
            }
        }
    }
}
