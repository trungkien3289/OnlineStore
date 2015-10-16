using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OnlineStore.Infrastructure.Domain;

namespace OnlineStore.Infrastructure.UnitOfWork
{
    public interface IUnitOfWork
    {
        void RegisterAmended(IAggregateRoot entity,
                             IUnitOfWorkRepository unitofWorkRepository);
        void RegisterNew(IAggregateRoot entity,
                         IUnitOfWorkRepository unitofWorkRepository);
        void RegisterRemoved(IAggregateRoot entity,
                             IUnitOfWorkRepository unitofWorkRepository);
        void Commit();
    }
}

