using AgendaOnline.Domain.Entities;
using AgendaOnline.Domain.Repositories;
using AgendaOnline.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaOnline.Infrastructure.NHibernate.Repositories
{
    public class ContactRepository : RepositoryBase<Contact>, IContactRepository
    {
        public Contact GetByName(Name name)
        {
            throw new NotImplementedException();
        }
    }
}
