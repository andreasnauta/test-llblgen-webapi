using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public interface IFullItemRepository<TEntity> where TEntity : class
    {
        TEntity GetFullItem(int id);
    }
}
