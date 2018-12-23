using AgendaOnline.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaOnline.Domain.Entities
{
    public class Phone
    {
        public virtual int Id { get; set; }        
        public virtual int Number { get; set; }
        public virtual ETypeRegistration Type { get; set; }
    }
}
