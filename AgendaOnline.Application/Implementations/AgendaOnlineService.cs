using AgendaOnline.Application.Contracts;
using AgendaOnline.Application.Messages;
using AgendaOnline.Domain.Entities;
using AgendaOnline.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AgendaOnline.Application.Implementations
{
    public class AgendaOnlineService : IAgendaOnlineService
    {

        private readonly IContactRepository _contactRepository;

        public AgendaOnlineService(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public async Task<SaveContactResponse> SaveContractAgendaOnline(SaveContactRequest request)
        {
            var saveContactRequest = new SaveContactRequest();
            var saveContactResponse = new SaveContactResponse();

            Contact contact = new Contact();           
            contact.Address = "Dom José Gaspar";
            
            
            contact.Company = "Microsoft";
            contact.Name = "Edgard";
            

            await _contactRepository.Save(contact);
            saveContactResponse.Valido = true;

            return saveContactResponse;
        }

        public async Task<IList<Contact>> GetListContact(FilterContactRequest request)
        {
            request = new FilterContactRequest();
            request.Email = "edgard1axl@msn.com";
            request.Name = "Edgard";
            //request.Phone = 964066989;

            var contacts = await _contactRepository.GetByFilter(request.Name, request.Phone, request.Email);

            return contacts;
        }

        public async Task<SaveContactResponse> UpdateContractAgendaOnline(SaveContactRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
