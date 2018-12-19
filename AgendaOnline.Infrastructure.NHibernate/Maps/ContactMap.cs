using AgendaOnline.Domain.Entities;
using FluentNHibernate.Mapping;


namespace AgendaOnline.Infrastructure.NHibernate.Maps
{
    public class ContactMap : ClassMap<Contact>
    {
        public ContactMap()
        {
            Table("contact");
            Id(x => x.Id, "Id");
            Map(x => x.Address).Column("street");
            Map(x => x.Company).Column("company");
            Map(x => x.Name).Column("name");            
        }
    }
}
