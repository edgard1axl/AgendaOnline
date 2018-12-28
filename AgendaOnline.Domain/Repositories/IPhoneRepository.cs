using AgendaOnline.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AgendaOnline.Domain.Repositories
{
    public interface IPhoneRepository
    {
        Task<IList<Phone>> SaveList(IList<Phone> phones);
    }
}
