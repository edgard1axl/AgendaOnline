using AgendaOnline.Application.Messages.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaOnline.Application.Messages
{
    public class FilterContactRequest : BaseRequest
    {
        public string Name { get; set; }
        public int? Phone { get; set; }
        public string Email { get; set; }
    }
}
