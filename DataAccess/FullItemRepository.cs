using EntityModel;
using EntityModel.DatabaseSpecific;
using EntityModel.EntityClasses;
using EntityModel.Linq;
using Repository;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using System.Linq;

namespace DataAccess
{
    public class FullItemRepository : IFullItemRepository<SpecificItemEntity>
    {
        public FullItemRepository(string connectionString)
        {
            LLBLGenConfiguration.Setup(connectionString);
        }

        public SpecificItemEntity GetFullItem(int id)
        {
            using (var adapter = new DataAccessAdapter())
            {
                var path = new PrefetchPath2(EntityType.SpecificItemEntity);

                var incidents = path.Add(SpecificItemEntity.PrefetchPathIncidents);

                var actorIncidents = incidents.SubPath.Add(IncidentEntity.PrefetchPathActorIncidents);

                var actors = actorIncidents.SubPath.Add(ActorIncidentEntity.PrefetchPathActor);
                actors.SubPath.Add(ActorEntity.PrefetchPathCollection);
  
                var data = new LinqMetaData(adapter);

                return data.SpecificItem.WithPath(path).Single(x => x.Id == id);
            }
        }
    }
}
