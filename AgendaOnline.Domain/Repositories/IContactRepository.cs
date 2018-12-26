using AgendaOnline.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AgendaOnline.Domain.Repositories
{
    public interface IContactRepository : IRepositoryBase<Contact>
    {
        IList<Contact> GetByName(string name);
        Task<IList<Contact>> GetByFilter(string name, int? phone, string email);
    }
}
