using AgendaOnline.Application.Contracts;
using AgendaOnline.Application.Implementations;
using AgendaOnline.Domain.Repositories;
using AgendaOnline.Infrastructure.NHibernate.Helper;
using AgendaOnline.Infrastructure.NHibernate.Repositories;
//using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using NHibernate;


namespace AgendaOnline.Infrastructure.DI
{
    public class Bootstrap
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddSingleton<Microsoft.AspNetCore.Http.IHttpContextAccessor, Microsoft.AspNetCore.Http.HttpContextAccessor>();

            //Domain Repositories
            services.AddScoped<IContactRepository, ContactRepository>();
            services.AddScoped<IEmailRepository, EmailRepository>();
            services.AddScoped<IPhoneRepository, PhoneRepository>();

            services.AddScoped<IAgendaOnlineService, AgendaOnlineService>();
            services.AddSingleton<ISessionFactory>(NHibernateHelper.ObterSessionFactory());
        }
    }
}
