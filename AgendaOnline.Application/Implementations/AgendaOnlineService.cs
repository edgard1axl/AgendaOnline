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
            contact.City = "Mauá";
            contact.Country = "Brasil";
            contact.Neighborhood = "Vila Assis";
            contact.Number = "100";
            contact.State = "SP";
            contact.Street = "Dom José Gaspar";
            contact.ZipCode = "09540080";
            contact.Complement = "proximo da goias";
            
            contact.Company = "Microsoft";
            contact.FirstName = "Edgard";
            

            await _contactRepository.Save(contact);
            saveContactResponse.Valido = true;

            return saveContactResponse;
        }
    }
}
