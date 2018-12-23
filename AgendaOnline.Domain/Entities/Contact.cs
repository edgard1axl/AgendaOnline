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
        public virtual int Id { get; set; }
        public virtual string Company { get; set; }
        public virtual IReadOnlyCollection<Phone> Phones { get; set; }        
        public virtual string Street { get; set; }
        public virtual string Number { get; set; }
        public virtual string Neighborhood { get; set; }
        public virtual string City { get; set; }
        public virtual string State { get; set; }
        public virtual string Country { get; set; }
        public virtual string ZipCode { get; set; }
        public virtual string Complement { get; set; }
        public virtual IReadOnlyCollection<EmailContact> Emails { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }

        public virtual void AddPhone(Phone phone)
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

        public virtual void AddEmail(EmailContact email)
        {
            if (email != null)
            {
                if (_emails.Count > 0)
                {
                    if (_emails.Where(x => x.Type == email.Type).ToList().Count == 0)
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
