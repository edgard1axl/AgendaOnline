using AgendaOnline.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgendaOnline.MVC.Models
{
    public class ContactViewModel
    {
        public IList<Contact> Contacts;

        public void MapContact(IList<Contact> contacts)
        {
            Contacts = contacts;   
        }
    }
}
