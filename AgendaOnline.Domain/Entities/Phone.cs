using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaOnline.Domain.Entities
{
    public class Phone
    {
        public Phone(int dddNumber, int number)
        {
            DddNumber = dddNumber;
            Number = number;
        }

        public int DddNumber { get; private set; }
        public int Number { get; private set; }

        
    }
}
