using AgendaOnline.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AgendaOnline.Domain.Repositories
{
    public interface IEmailRepository : IRepositoryBase<EmailContact>
    {
        Task<IList<EmailContact>> SaveList(IList<EmailContact> emails);
        IList<EmailContact> GetByEmail(string address);
    }
}
