using System;
using System.Collections.Generic;
using OnlineStore.Infrastructure.Domain;
using OnlineStore.Infrastructure.Querying;
using OnlineStore.Infrastructure.UnitOfWork;
using System.Data.Entity;
using OnlineStore.Repository.Entity.MetaData;

namespace OnlineStore.Repository.Entity.Repositories
{
    public abstract class Repository<T, TEntityKey> where T : class,IAggregateRoot
    {
        private IUnitOfWork _uow;
        private readonly IContext<T> _context;

        public Repository(IUnitOfWork uow)
        {
            _uow = uow;
            _context = new Context<T>();
        }

        public void Add(T entity)
        {
            _context.DbSet.Add(entity);
        }

        public void Remove(T entity)
        {
            _context.DbSet.Remove(entity);
        }

        public T Save(T entity)
        {
            var updated = _context.DbSet.Attach(entity);
            _context.DbContext.Entry(entity).State = EntityState.Modified;
            return updated;
        }

        public T FindBy(TEntityKey id)
        {
            return _context.DbSet.Find(id);
        }

        public IEnumerable<T> FindAll()
        {
            return _context.DbSet;
        }

        //public IEnumerable<T> FindAll(int index, int count)
        //{
        //    //ICriteria criteriaQuery =
        //    //          SessionFactory.GetCurrentSession().CreateCriteria(typeof(T));

        //    //return (List<T>)criteriaQuery.SetFetchSize(count)
        //    //                        .SetFirstResult(index).List<T>();
        //}

        //public IEnumerable<T> FindBy(Query query)
        //{
        //    //ICriteria criteriaQuery =
        //    //         SessionFactory.GetCurrentSession().CreateCriteria(typeof(T));

        //    //AppendCriteria(criteriaQuery);

        //    //query.TranslateIntoNHQuery<T>(criteriaQuery);

        //    //return criteriaQuery.List<T>();
        //}

        //public IEnumerable<T> FindBy(Query query, int index, int count)
        //{
        //    //ICriteria criteriaQuery =
        //    //         SessionFactory.GetCurrentSession().CreateCriteria(typeof(T));

        //    //AppendCriteria(criteriaQuery);

        //    //query.TranslateIntoNHQuery<T>(criteriaQuery);

        //    //return criteriaQuery.SetFetchSize(count).SetFirstResult(index).List<T>();
        //}

        //public virtual void AppendCriteria(ICriteria criteria)
        //{

        //}
    }

}
