using Dto.DtoClasses;
using Dto.Persistence;
using EntityModel.DatabaseSpecific;
using EntityModel.EntityClasses;
using EntityModel.Linq;
using Repository;
using System.Linq;

namespace DataAccess
{
    public class SpecificItemRepository : IRepository<SpecificItemDto>
    {
        public SpecificItemRepository(string connectionString)
        {
            LLBLGenConfiguration.Setup(connectionString);
        }

        public IQueryable<SpecificItemDto> GetAll()
        {
            using (var adapter = new DataAccessAdapter())
            {
                var data = new LinqMetaData(adapter);

                return data.SpecificItem.ProjectToSpecificItemDto();
            }
        }

        public SpecificItemDto GetById(int id)
        {
            using (var adapter = new DataAccessAdapter())
            {
                var data = new LinqMetaData(adapter);

                //We need to do this extra call as per https://www.llblgen.com/Documentation/5.3/Derived%20Models/dto_llblgen.htm#example-projection-on-database-query
                var result = data.SpecificItem.Where(x => x.Id == id).ProjectToSpecificItemDto().ToList();

                return result[0];
            }
        }

        public SpecificItemDto Insert(SpecificItemDto entity)
        {
            return InsertOrUpdate(entity);
        }

        public SpecificItemDto Update(SpecificItemDto entity)
        {
            return InsertOrUpdate(entity);
        }

        public void Delete(int id)
        {
            using (var adapter = new DataAccessAdapter())
            {
                var data = new LinqMetaData(adapter);

                var entity = data.SpecificItem.Single(x => x.Id == id);

                if (entity != null)
                {
                    adapter.DeleteEntity(entity);
                }
            }
        }

        private SpecificItemDto InsertOrUpdate(SpecificItemDto dto)
        {
            using (var adapter = new DataAccessAdapter())
            {
                var data = new LinqMetaData(adapter);

                var entity = data.SpecificItem.FirstOrDefault(SpecificItemDtoPersistence.CreatePkPredicate(dto));

                if (entity == null)
                {
                    entity = new SpecificItemEntity();
                }

                entity.UpdateFromSpecificItemDto(dto);

                adapter.SaveEntity(entity, true);

                //We need to do this extra call as per https://www.llblgen.com/Documentation/5.3/Derived%20Models/dto_llblgen.htm#example-projection-on-database-query
                var result = data.SpecificItem.Where(x => x.Id == entity.Id).ProjectToSpecificItemDto().ToList();

                return result[0];
            }
        }
    }
}
