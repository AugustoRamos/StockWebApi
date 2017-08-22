using Domain.Models;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace Bradop.StockWebApi.Helper
{
    public class NHibernateHelper
    {
        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }


        private static ISessionFactory _sessionFactory;
        const string ConnectionString = @"Data Source=192.168.1.15\SQLEXPRESSCZR;Initial Catalog=CzrSkl_01_0001;Persist Security Info=True;User ID=sa;Password=Uc1qS2dQ";
        private static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                    CreateSessionFactory();

                return _sessionFactory;
            }
        }

        private static void CreateSessionFactory()
        {
            _sessionFactory = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2008.ConnectionString(ConnectionString).ShowSql)
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Stock>())
                .ExposeConfiguration(cfg => new SchemaExport(cfg).Create(false, false))
                .BuildSessionFactory();
        }
    }
}