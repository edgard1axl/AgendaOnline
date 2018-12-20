using AgendaOnline.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AgendaOnline.Domain.Entities
{
    public class Contact
    {
        private IList<EmailContact> _emails;
        private IList<Phone> _phones;

        public Contact(Company company, Address address, Name name)
        {
            Company = company;
            _phones = new List<Phone>();
            Address = address;
            _emails = new List<EmailContact>();
            Name = name;
        }

        public virtual int Id { get; }
        public virtual Company Company { get; private set; }
        public virtual IReadOnlyCollection<Phone> Phones { get { return _phones.ToArray(); } }
        public virtual Address Address { get; private set; }
        public virtual IReadOnlyCollection<EmailContact> Emails { get { return _emails.ToArray(); } }
        public virtual Name Name { get; private set; }

        public void AddPhone(Phone phone)
        {
            if(phone != null)
            {
                if(_phones.Count > 0)
                {
                    if(_phones.Where(x => x.Type == phone.Type).ToList().Count == 0)
                    {
                        _phones.Add(phone);
                    }
                }
                else
                {
                    _phones.Add(phone);
                }

            }
        }

        public void AddEmail(EmailContact email)
        {
            if (email != null)
            {
                if (_emails.Count > 0)
                {
                    if (_emails.Where(x => x.Email.Type == email.Email.Type).ToList().Count == 0)
                    {
                        _emails.Add(email);
                    }
                }
                else
                {
                    _emails.Add(email);
                }

            }
        }
    }
}
