using AgendaOnline.Application.Messages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AgendaOnline.Application.Contracts
{
    public interface IAgendaOnlineService
    {
        Task<SaveContactResponse> SaveContractAgendaOnline(SaveContactRequest request);
    }
}
