using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AgendaOnline.Domain.Repositories
{
    public interface IRepositoryBase<T> where T : class
    {
        T GetById(int id);
        IList<T> GetAll();
        IList<T> ReturnByHql(string hql);
        Task<T> Save(T item);
        T Delete(T item);
        T Update(T entity);
    }
}
