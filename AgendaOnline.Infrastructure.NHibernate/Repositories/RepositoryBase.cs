using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgendaOnline.Domain.Repositories;
using AgendaOnline.Infrastructure.NHibernate.Helper;
using NHibernate;

namespace AgendaOnline.Infrastructure.NHibernate.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private ISessionFactory _sessionFactory;
        private ISession _session;

        public RepositoryBase(ISessionFactory sessionFactoty)
        {
            _sessionFactory = sessionFactoty;
        }

        public T GetById(int id)
        {
            using (_session = _sessionFactory.OpenSession())
                return _session.Get<T>(id);
        }

        public IList<T> GetAll()
        {
            using (_session = _sessionFactory.OpenSession())
                return _session.QueryOver<T>().List();
        }

        public IList<T> ReturnByHql(string hql)
        {
            using (_session = _sessionFactory.OpenSession())
                return _session.CreateQuery(hql).List<T>();
        }

        public async Task<T> Save(T entity)
        {
            try
            {                
                using (_session = _sessionFactory.OpenSession())
                {
                    using (ITransaction transaction = _session.BeginTransaction())
                    {
                        await _session.SaveAsync(entity);
                        await transaction.CommitAsync();                        
                    }
                }
            }
            catch(Exception ex)
            {
                throw new Exception();
            }
            return entity;
        }

        public T Update(T entity)
        {
            using (_session = _sessionFactory.OpenSession())
            {
                using (ITransaction transaction = _session.BeginTransaction())
                {
                    _session.UpdateAsync(entity);
                    transaction.Commit();
                }
            }
            return entity;
        }
        public T Delete(T entity)
        {
            using (_session = _sessionFactory.OpenSession())
            {
                using (ITransaction transaction = _session.BeginTransaction())
                {
                    _session.DeleteAsync(entity);
                    transaction.Commit();
                }
            }
            return entity;
        }        
    }
}
