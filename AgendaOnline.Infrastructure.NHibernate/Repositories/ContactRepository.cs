using AgendaOnline.Domain.Entities;
using AgendaOnline.Domain.Repositories;
using AgendaOnline.Infrastructure.NHibernate.Helper;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.SqlCommand;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AgendaOnline.Infrastructure.NHibernate.Repositories
{
    public class ContactRepository : RepositoryBase<Contact>, IContactRepository
    {

        public ContactRepository(ISessionFactory sessionFactory)
            : base(sessionFactory)
        { }

        public IList<Contact> GetByName(string name)
        {
            IList<Contact> contacts;

            using (ISession session = NHibernateHelper.OpenSession())
            {
                contacts = session.QueryOver<Contact>()
                    .Where(c => c.Name == name)
                    .List();
            }

            return contacts;
        }

        public async Task<IList<Contact>> GetByFilter(string name, int? phone, string email)
        {

            IList<Contact> contacts;
            Phone phoneAlias = null;
            EmailContact emailAlias = null;
            Contact contactAlias = null;           

            try
            {
                using (ISession session = NHibernateHelper.OpenSession())
                {
                    var disjunction = new Disjunction();

                    if(!string.IsNullOrEmpty(name))
                        disjunction.Add(Restrictions.On(() => contactAlias.Name).IsLike(name, MatchMode.Start ));
                    if (phone != null)
                        disjunction.Add(Restrictions.On(() => phoneAlias.Number).IsLike(phone));
                    if(!string.IsNullOrEmpty(email))
                        disjunction.Add(Restrictions.On(() => emailAlias.Address).IsLike(email, MatchMode.Start));


                    contacts = await session.QueryOver<Contact>(() => contactAlias)
                        .JoinAlias(p => p.Phones, () => phoneAlias)
                        .JoinAlias(p => p.Emails, () => emailAlias)
                        .Where(disjunction)
                        .OrderBy(p => p.Name).Asc
                        .ListAsync<Contact>();                    

                    return contacts;
                }
            }
            catch(Exception ex)
            {

            }

            return null;
        }
    }
}
