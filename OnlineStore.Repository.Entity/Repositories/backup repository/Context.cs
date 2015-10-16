using OnlineStore.Infrastructure.Domain;
using OnlineStore.Repository.Entity.MetaData;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Repository.Entity.Repositories
{
    public class Context<T> : IContext<T> where T : class,IAggregateRoot
    {
        public Context()
        {
            DbContext = new OnlineStoreEntities();
            DbSet = DbContext.Set<T>();
        }
        public void Dispose()
        {

        }
        public DbContext DbContext { get; private set; }

        public IDbSet<T> DbSet { get; private set; }
    }
}
