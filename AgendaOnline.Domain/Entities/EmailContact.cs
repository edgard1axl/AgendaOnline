using AgendaOnline.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaOnline.Domain.Entities
{
    public class EmailContact
    {     
        public virtual int Id { get; set; }
        public virtual string Address { get; set; }
        public virtual ETypeRegistration Type { get; set; }
        public virtual Contact Contact { get; set; } 
    }
}
