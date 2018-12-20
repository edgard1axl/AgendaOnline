using AgendaOnline.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaOnline.Domain.Entities
{
    public class EmailContact
    {
        public EmailContact(int id, Email email)
        {
            Id = id;
            Email = email;
        }

        public virtual int Id { get; private set; }
        public virtual Email Email { get; private set; }
    }
}
