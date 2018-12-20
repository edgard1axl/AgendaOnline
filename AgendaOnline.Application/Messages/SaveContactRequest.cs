using AgendaOnline.Application.Messages.Base;
using AgendaOnline.Domain.Entities;
using AgendaOnline.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaOnline.Application.Messages
{
    public class SaveContactRequest : BaseRequest
    {
        public Contact Contact { get; set; }
    }
}
