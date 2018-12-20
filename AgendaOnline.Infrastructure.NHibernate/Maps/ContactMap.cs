using AgendaOnline.Domain.Entities;
using FluentNHibernate.Mapping;


namespace AgendaOnline.Infrastructure.NHibernate.Maps
{
    public class ContactMap : ClassMap<Contact>
    {
        public ContactMap()
        {
            Table("contact");
            Id(x => x.Id).Column("id");
            Map(x => x.Address).Column("street");
            Map(x => x.Company).Column("company");
            Map(x => x.Name).Column("name");
            Map(x => x.Address.City).Column("city");
            Map(x => x.Address.Country).Column("country");
            Map(x => x.Address.Neighborhood).Column("neighborhood");
            Map(x => x.Address.Number).Column("address");
            Map(x => x.Address.State).Column("state");
            Map(x => x.Address.Street).Column("street");
            Map(x => x.Address.ZipCode).Column("zipcode");
            Map(x => x.Company).Column("company");            
        }
    }
}
