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
    public class CollectionRepository : IRepository<CoreCollectionDto>
    {
        public CollectionRepository(string connectionString)
        {
            LLBLGenConfiguration.Setup(connectionString);
        }

        public List<CoreCollectionDto> GetAll()
        {
            using (var adapter = new DataAccessAdapter())
            {
                var data = new LinqMetaData(adapter);

                return data.Collection.ProjectToCoreCollectionDto().ToList();
            }
        }

        public CoreCollectionDto Get(int id)
        {
            using (var adapter = new DataAccessAdapter())
            {
                var data = new LinqMetaData(adapter);

                //We need to do this extra call as per https://www.llblgen.com/Documentation/5.3/Derived%20Models/dto_llblgen.htm#example-projection-on-database-query
                var result = data.Collection.Where(x => x.Id == id).ProjectToCoreCollectionDto().ToList();

                return result[0];
            }
        }

        public CoreCollectionDto Insert(CoreCollectionDto entity)
        {
            return InsertOrUpdate(entity);
        }

        public CoreCollectionDto Update(CoreCollectionDto entity)
        {
            return InsertOrUpdate(entity);
        }

        public void Delete(int id)
        {
            using (var adapter = new DataAccessAdapter())
            {
                var data = new LinqMetaData(adapter);

                var entity = data.Collection.Single(x => x.Id == id);

                if (entity != null)
                {
                    adapter.DeleteEntity(entity);
                }
            }
        }

        private CoreCollectionDto InsertOrUpdate(CoreCollectionDto dto)
        {
            using (var adapter = new DataAccessAdapter())
            {
                var data = new LinqMetaData(adapter);

                var entity = data.Collection.FirstOrDefault(CoreCollectionDtoPersistence.CreatePkPredicate(dto));

                if (entity == null)
                {
                    entity = new CollectionEntity();
                }

                entity.UpdateFromCoreCollectionDto(dto);

                adapter.SaveEntity(entity, true);

                //We need to do this extra call as per https://www.llblgen.com/Documentation/5.3/Derived%20Models/dto_llblgen.htm#example-projection-on-database-query
                var result = data.Collection.Where(x => x.Id == entity.Id).ProjectToCoreCollectionDto().ToList();

                return result[0];
            }
        }
    }
    

}
