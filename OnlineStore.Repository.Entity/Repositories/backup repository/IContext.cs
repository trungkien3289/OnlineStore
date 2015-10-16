using OnlineStore.Infrastructure.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Repository.Entity.Repositories
{
    public interface IContext<T> : IDisposable where T : IAggregateRoot
    {
        DbContext DbContext { get; }
        IDbSet<T> DbSet { get; }
    }
}
