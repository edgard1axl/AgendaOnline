using AgendaOnline.Application.Contracts;
using AgendaOnline.Application.Messages;
using AgendaOnline.Domain.Entities;
using AgendaOnline.Domain.Repositories;
using AgendaOnline.Domain.ValueObjects;
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

            Company company = new Company("Microsoft");
            Address address = new Address("Rua", "123", "Centro", "São Paulo", "SP", "Brasil", "09540080");
            Name name = new Name("Edgard", "Santos");

            Contact contact = new Contact(company, address, name);

            await _contactRepository.Save(contact);
            saveContactResponse.Valido = true;

            return saveContactResponse;
        }
    }
}
