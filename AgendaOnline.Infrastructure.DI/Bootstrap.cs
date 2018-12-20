using Enterprise.Framework.Collections;
using Enterprise.Framework.DI;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace AgendaOnline.Infrastructure.DI
{
    public class Bootstrap
    {
        private readonly ParsableNameValueCollection _appSettings;
        private readonly Factory _factory = Factory.Instance;

        public Bootstrap() { }

        public Bootstrap(ParsableNameValueCollection appSettings)
        {
            if ((_appSettings = appSettings) == null)
                throw new ArgumentException("appSettings");
        }

        public void Initialize(IServiceCollection services)
        {
            _factory.Register(_appSettings);
            RegisterWebApiSecurity(services);
        }

        private void RegisterWebApiSecurity(IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, Microsoft.AspNetCore.Http.HttpContextAccessor>();
        }
    }
}
