using AgendaOnline.Domain.Entities;
using AgendaOnline.Domain.Repositories;
using AgendaOnline.Infrastructure.NHibernate.Helper;
using NHibernate;
using System;
using System.Collections.Generic;


namespace AgendaOnline.Infrastructure.NHibernate.Repositories
{
    public class ContactRepository : RepositoryBase<Contact>, IContactRepository
    {

        public ContactRepository(ISessionFactory sessionFactory)
            :base(sessionFactory)
        { }

        public IList<Contact> GetByName(string name)
        {
            IList<Contact> contacts;

            using (ISession session = NHibernateHelper.OpenSession())
            {
                contacts = session.QueryOver<Contact>()
                    .Where(c => c.FirstName == name)
                    .List();
            }

            return contacts;
        }       
        
    }
}
