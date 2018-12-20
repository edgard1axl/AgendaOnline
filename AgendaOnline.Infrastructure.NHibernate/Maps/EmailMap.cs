using AgendaOnline.Domain.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaOnline.Infrastructure.NHibernate.Maps
{
    public class EmailMap : ClassMap<EmailContact>
    {
        public EmailMap()
        {
            Table("email");
            Id(x => x.Id).Column("id");
            Map(x => x.Email.Address).Column("address");
            Map(x => x.Email.Type).Column("idTypeRegister");
        }
    }
}
