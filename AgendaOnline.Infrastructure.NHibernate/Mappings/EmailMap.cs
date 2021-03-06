﻿using AgendaOnline.Domain.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaOnline.Infrastructure.NHibernate.Mapppings
{
    public class EmailMap : ClassMap<EmailContact>
    {
        public EmailMap()
        {
            Table("email");
            Id(x => x.Id).Column("id");
            Map(x => x.Address).Column("address");
            Map(x => x.Type).Column("idTypeRegister").CustomType<int>();

            References(x => x.Contact).Cascade.Merge().Column("idContact");
        }
    }
}
