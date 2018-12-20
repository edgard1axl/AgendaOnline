using AgendaOnline.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaOnline.Domain.Entities
{
    public class Phone
    {
        public Phone(int dddNumber, int number, ETypeRegistration type)
        {            
            Number = number;
            Type = type;
        }

        public int Id { get; private set; }        
        public int Number { get; private set; }
        public ETypeRegistration Type { get; private set; }
    }
}
