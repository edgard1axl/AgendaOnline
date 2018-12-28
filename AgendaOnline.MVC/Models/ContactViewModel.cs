using AgendaOnline.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgendaOnline.MVC.Models
{
    public class ContactViewModel
    {
        public string Name { get; set; }
        public string Adress { get; set; }        
        public string EmailHome { get; set; }
        public string EmailWork { get; set; }
        public string EmailOther { get; set; }
        public string Company { get; set; }
        public string PhoneHome { get; set; }
        public string PhoneWork { get; set; }
        public string PhoneOther { get; set; }

        public Contact MapModelToContact(ContactViewModel model)
        {
            Contact contact = new Contact();

            try
            {           
                contact.AddEmail(new EmailContact()
                {
                    Address = model.EmailHome,
                    Type = Domain.Enums.ETypeRegistration.casa
                });

                contact.AddEmail(new EmailContact()
                {
                    Address = model.EmailWork,
                    Type = Domain.Enums.ETypeRegistration.trabalho
                });

                contact.AddEmail(new EmailContact()
                {
                    Address = model.EmailOther,
                    Type = Domain.Enums.ETypeRegistration.outro
                });

                if (model.PhoneHome != null)
                {
                    contact.AddPhone(new Domain.Entities.Phone()
                    {
                        Number = int.Parse(model.PhoneHome),
                        Type = Domain.Enums.ETypeRegistration.casa
                    });
                }

                if (model.PhoneWork != null)
                {
                    contact.AddPhone(new Domain.Entities.Phone()
                    {
                        Number = int.Parse(model.PhoneWork),
                        Type = Domain.Enums.ETypeRegistration.trabalho
                    });
                }
                if (model.PhoneOther != null)
                {
                    contact.AddPhone(new Domain.Entities.Phone()
                    {
                        Number = int.Parse(model.PhoneOther),
                        Type = Domain.Enums.ETypeRegistration.outro
                    });
                }

                contact.Address = model.Adress;
                contact.Company = model.Company;
                contact.Name = model.Name;
            }
            catch(Exception ex) { }

            return contact;
        }
    }

    
}
