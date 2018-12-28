using AgendaOnline.Domain.Entities;
using AgendaOnline.Domain.Repositories;
using AgendaOnline.Infrastructure.NHibernate.Helper;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AgendaOnline.Infrastructure.NHibernate.Repositories
{
    public class PhoneRepository : RepositoryBase<Phone>, IPhoneRepository
    {
        public PhoneRepository(ISessionFactory sessionFactory)
            : base(sessionFactory)
        { }

        public IList<Phone> GetByPhone(int number)
        {
            IList<Phone> phones;

            using (ISession session = NHibernateHelper.OpenSession())
            {
                phones = session.QueryOver<Phone>()
                    .Where(e => e.Number == number)
                    .List();
            }

            return phones;
        }

        public async Task<IList<Phone>> SaveList(IList<Phone> phones)
        {
            ISession session = NHibernateHelper.OpenSession();

            using (var tran = session.BeginTransaction())
            {
                try
                {
                    session.Clear();
                    session.SetBatchSize(phones.Count);
                    foreach (var item in phones)
                    {
                        await session.SaveAsync(item);
                    }
                    tran.Commit();
                }
                catch (Exception ex)
                {
                    if (!tran.WasCommitted)
                    {
                        tran.Rollback();
                    }
                    throw new Exception("Erro ao salvar os registros: " + ex.Message);
                }
            }

            return phones;
        }
    }
}
