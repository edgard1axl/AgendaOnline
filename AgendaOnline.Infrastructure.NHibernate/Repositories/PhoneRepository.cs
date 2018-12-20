using AgendaOnline.Domain.Entities;
using AgendaOnline.Infrastructure.NHibernate.Helper;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaOnline.Infrastructure.NHibernate.Repositories
{
    public class PhoneRepository
    {
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
    }
}
