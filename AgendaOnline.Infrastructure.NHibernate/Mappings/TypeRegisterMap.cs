using AgendaOnline.Domain.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaOnline.Infrastructure.NHibernate.Mappings
{
    public class TypeRegisterMap : ClassMap<TypeRegister>
    {
        public TypeRegisterMap()
        {
            Table("typeRegister");

            Id(x => x.Id).GeneratedBy.Identity().Column("Id");
            Map(x => x.Name).Column("name");

        }
    }
}
