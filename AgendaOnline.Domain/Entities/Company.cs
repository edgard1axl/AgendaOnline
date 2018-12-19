using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaOnline.Domain.Entities
{
    public class Company
    {
        public Company(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }
    }
}
