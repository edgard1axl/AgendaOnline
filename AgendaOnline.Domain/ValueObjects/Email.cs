using AgendaOnline.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaOnline.Domain.ValueObjects
{
    public class Email
    {
        public Email(string address, ETypeRegistration type)
        {
            Address = address;
            Type = type;
        }

        public string Address { get; private set; }
        public ETypeRegistration Type { get; private set; }        
    }
}
