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
        }
    }
}
