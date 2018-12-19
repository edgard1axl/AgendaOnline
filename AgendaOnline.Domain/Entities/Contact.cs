using AgendaOnline.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaOnline.Domain.Entities
{
    public class Contact
    {
        public Contact(Company company, Phone phone, Address address, Email email, Name name)
        {
            Company = company;
            Phone = phone;
            Address = address;
            Email = email;
            Name = name;
        }

        public int Id { get; }
        public Company Company { get; private set; }
        public Phone Phone { get; private set; }
        public Address Address { get; private set; }
        public Email Email { get; private set; }
        public Name Name { get; private set; }
    }
}
