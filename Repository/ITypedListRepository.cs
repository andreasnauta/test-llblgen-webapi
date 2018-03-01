using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public interface ITypedListRepository<TEntity> where TEntity : class
    {
        TEntity GetInflated(int id);
    }
}
