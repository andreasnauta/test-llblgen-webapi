using EntityModel.DatabaseSpecific;
using EntityModel.Linq;
using EntityModel.TypedListClasses;
using Repository;
using System.Linq;

namespace DataAccess
{
    public class SpecificItemTypedListRepository : ITypedListRepository<SpecificItemTypedListRow>
    {
        public SpecificItemTypedListRepository(string connectionString)
        {
            LLBLGenConfiguration.Setup(connectionString);
        }

        public SpecificItemTypedListRow GetInflated(int id)
        {
            using (var adapter = new DataAccessAdapter())
            {
                var data = new LinqMetaData(adapter);

                return data.GetSpecificItemTypedListTypedList().Single(x => x.Id == id);
            }
        }
    }
}
