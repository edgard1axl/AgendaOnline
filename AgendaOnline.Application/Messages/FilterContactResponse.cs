using AgendaOnline.Application.Messages.Base;
using AgendaOnline.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaOnline.Application.Messages
{
    public class FilterContactResponse : BaseResponse
    {
        public IList<Contact> Contacts = new List<Contact>();

        //public static IList<FilterContactResponse> MapearFilterContractResponse(IList<Contact> contacts)
        //{
        //    if (contacts == null)
        //        throw new ArgumentException("contacts não pode ser nulo!");

        //    IList<FilterContactResponse> filterContacts = new List<FilterContactResponse>();

        //    Contacts = contacts;

        //    foreach (var item in contacts)
        //    {
        //        var filterContact = new FilterContactResponse();
        //        filterContact.Address = item.Address;
        //        filterContact.Name = item.Name;
        //        filterContact.Phones = item.Phones;
        //        filterContact.Emails = item.Emails;

        //        filterContacts.Add(filterContact);
        //    }

        //    return filterContacts;
        //}
    }
}
