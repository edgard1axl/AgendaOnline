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
    public class EmailRepository : RepositoryBase<EmailContact>, IEmailRepository
    {

        public EmailRepository(ISessionFactory sessionFactory)
            :base(sessionFactory)
        { }

        public IList<EmailContact> GetByEmail(string address)
        {
            IList<EmailContact> emails;

            using (ISession session = NHibernateHelper.OpenSession())
            {
                emails = session.QueryOver<EmailContact>()
                    .Where(e => e.Address == address)
                    .List();
            }

            return emails;
        }

        public async Task<IList<EmailContact>> SaveList(IList<EmailContact> emails)
        {
            ISession session = NHibernateHelper.OpenSession();

            using (var tran = session.BeginTransaction())
            {
                try
                {
                    session.Clear();                    
                    session.SetBatchSize(emails.Count);
                    foreach (var item in emails)
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

            return emails;
        }
    }
}
