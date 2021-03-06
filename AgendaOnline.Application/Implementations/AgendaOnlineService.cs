﻿using AgendaOnline.Application.Contracts;
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
        private readonly IEmailRepository _emailRepository;
        private readonly IPhoneRepository _phoneRepository;

        public AgendaOnlineService(IContactRepository contactRepository, IEmailRepository emailRepository, IPhoneRepository phoneRepository)
        {
            _contactRepository = contactRepository;
            _emailRepository = emailRepository;
            _phoneRepository = phoneRepository;
        }

        public async Task<SaveContactResponse> SaveContractAgendaOnline(SaveContactRequest request)
        {            
            var saveContactResponse = new SaveContactResponse();     

            await _contactRepository.Save(request.Contact);

            foreach (var item in request.Contact.Emails)
            {
                item.Contact = request.Contact;
            }

            foreach (var item in request.Contact.Phones)
            {
                item.Contact = request.Contact;
            }

            await _emailRepository.SaveList(request.Contact.Emails);
            await _phoneRepository.SaveList(request.Contact.Phones);           

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
