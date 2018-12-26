using AgendaOnline.Application.Messages;
using AgendaOnline.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AgendaOnline.Application.Contracts
{
    public interface IAgendaOnlineService
    {
        Task<SaveContactResponse> SaveContractAgendaOnline(SaveContactRequest request);
        Task<IList<Contact>> GetListContact(FilterContactRequest request);
    }
}
