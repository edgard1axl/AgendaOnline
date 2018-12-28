using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AgendaOnline.Domain.Entities
{
    public class Contact
    {       
        public virtual int Id { get; set; }
        public virtual string Company { get; set; }
        public virtual IList<Phone> Phones { get; set; }        
        public virtual string Address { get; set; }       
        public virtual IList<EmailContact> Emails { get; set; }
        public virtual string Name { get; set; }       

        public virtual void AddPhone(Phone phone)
        {
            if(phone != null)
            {
                if(Phones?.Count > 0)
                {
                    if(Phones.Where(x => x.Type == phone.Type).ToList().Count == 0)
                    {
                        Phones.Add(phone);
                    }
                }
                else
                {
                    Phones = new List<Phone>();
                    Phones.Add(phone);
                }

            }
        }

        public virtual void AddEmail(EmailContact email)
        {
            if (email != null)
            {
                if (Emails?.Count > 0)
                {
                    if (Emails.Where(x => x.Type == email.Type).ToList().Count == 0)
                    {
                        Emails.Add(email);
                    }
                }
                else
                {
                    Emails = new List<EmailContact>();
                    Emails.Add(email);
                }

            }
        }
    }
}
