using AgendaOnline.Domain.Entities;
using AgendaOnline.Domain.Repositories;
using AgendaOnline.Infrastructure.NHibernate.Helper;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
