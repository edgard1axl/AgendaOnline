using AgendaOnline.Domain.Entities;
using FluentNHibernate;
using FluentNHibernate.Mapping;


namespace AgendaOnline.Infrastructure.NHibernate.Mapppings
{
    public class ContactMap : ClassMap<Contact>
    {
        public ContactMap()
        {
            Table("contact");
            Id(x => x.Id).GeneratedBy.Identity().Column("id");
            Map(x => x.Address).Column("address");
            Map(x => x.Company).Column("company");
            Map(x => x.Name).Column("name");           
            
            HasMany(x => x.Phones).Inverse().Cascade.Delete().KeyColumn("idContact");
            HasMany(x => x.Emails).Inverse().Cascade.Delete().KeyColumn("idContact");
        }
    }
}
