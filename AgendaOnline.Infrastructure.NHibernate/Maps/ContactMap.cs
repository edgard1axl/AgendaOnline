using AgendaOnline.Domain.Entities;
using FluentNHibernate;
using FluentNHibernate.Mapping;


namespace AgendaOnline.Infrastructure.NHibernate.Maps
{
    public class ContactMap : ClassMap<Contact>
    {
        public ContactMap()
        {
            Table("contact");
            Id(x => x.Id).GeneratedBy.Identity().Column("id");
            Map(x => x.Street).Column("street");
            Map(x => x.Company).Column("company");
            Map(x => x.FirstName).Column("name");
            Map(x => x.City).Column("city");
            Map(x => x.Country).Column("country");
            Map(x => x.Neighborhood).Column("neighborhood");
            Map(x => x.Number).Column("numberaddress");
            Map(x => x.State).Column("state");            
            Map(x => x.ZipCode).Column("zipcode");
            Map(x => x.Complement).Column("complementaddress");
        }
    }
}
