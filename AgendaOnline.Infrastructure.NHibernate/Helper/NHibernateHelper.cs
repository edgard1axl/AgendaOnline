﻿using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace AgendaOnline.Infrastructure.NHibernate.Helper
{
    public class NHibernateHelper
    {
        private static ISessionFactory _sessionFactory;

        public static ISession OpenSession()
        {
            return SessionFactory().OpenSession();
        }

        public static ISessionFactory ObterSessionFactory()
        {
            return SessionFactory();
        }

        private static ISessionFactory SessionFactory()
        {
            if (_sessionFactory != null)
            {
                return _sessionFactory;
            }

            var config = Fluently.Configure()
                    .Database(MySQLConfiguration.Standard.ConnectionString(
                c => c.Database("agendaonline1").Server("agendaonline1.mysql.uhserver.com").Username("agendaonline").Password("Edgard1axl!@")

                    )
                )
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<NHibernateHelper>())
                .ExposeConfiguration(c => c.Properties.Add("hbm2ddl.keywords", "auto-quote"))
                .ExposeConfiguration(c => c.Properties.Add("adonet.batch_size", "1"))
              // Cria as tabelas do Banco de Dados

              //.ExposeConfiguration(cfg =>
              //{
              //    new SchemaUpdate(cfg)
              //      .Execute(false, true);
              //})
                //.ExposeConfiguration(cfg =>
                //{
                //    new SchemaExport(cfg)
                //    .Create(false, true);
                //})
                .BuildSessionFactory();

            return _sessionFactory = config;
        }
    }
}
