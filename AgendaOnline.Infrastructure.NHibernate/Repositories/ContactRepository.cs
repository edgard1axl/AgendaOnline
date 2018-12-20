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
        public IList<Contact> GetByName(string name)
        {
            IList<Contact> contacts;

            using (ISession session = NHibernateHelper.OpenSession())
            {
                contacts = session.QueryOver<Contact>()
                    .Where(c => c.Name.FirstName == name)
                    .List();
            }

            return contacts;
        }
        
    }
}
