using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaOnline.Domain.Repositories
{
    public interface IRepositoryBase<T> where T : class
    {
        T GetById(int id);
        IList<T> GetAll();
        IList<T> ReturnByHql(string hql);
        T Save(T item);
        T Delete(T item);
    }
}
