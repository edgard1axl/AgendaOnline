using AgendaOnline.Domain.Entities;
using FluentNHibernate.Conventions.Helpers;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaOnline.Infrastructure.NHibernate.Maps
{
    public class PhoneMap : ClassMap<Phone>
    {
        public PhoneMap()
        {
            Table("phone");
            Id(x => x.Id).Column("id");
            Map(x => x.Number).Column("number");
            Map(x => x.Type).Column("idTypeRegister")
            .Not.LazyLoad();
        }
    }
}
