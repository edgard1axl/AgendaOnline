using System.Collections.Generic;
using System.Linq;
using AgendaOnline.Domain.Repositories;
using AgendaOnline.Infrastructure.NHibernate.Helper;
using NHibernate;

namespace AgendaOnline.Infrastructure.NHibernate.Repositories
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        public T GetById(int id)
        {
            using (ISession session = NHibernateHelper.OpenSession())
                return session.Get<T>(id);
        }

        public IList<T> GetAll()
        {
            using (ISession session = NHibernateHelper.OpenSession())
                return session.QueryOver<T>().List();
        }

        public IList<T> ReturnByHql(string hql)
        {
            using (ISession session = NHibernateHelper.OpenSession())
                return session.CreateQuery(hql).List<T>();
        }

        public T Save(T entity)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.SaveAsync(entity);
                    transaction.Commit();
                }
            }
            return entity;
        }

        public T Update(T entity)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.UpdateAsync(entity);
                    transaction.Commit();
                }
            }
            return entity;
        }
        public T Delete(T entity)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.DeleteAsync(entity);
                    transaction.Commit();
                }
            }
            return entity;
        }        
    }
}
