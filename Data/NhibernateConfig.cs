using System.Reflection;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Mapping.Attributes;

namespace TestTask.Data
{
    public static class NhibernateConfig
    {
        private static ISessionFactory _sessionFactory;
         
        public static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                {
                    var configuration = new Configuration();
                    configuration.DataBaseIntegration(db =>
                    {
                        db.ConnectionString = "Server=localhost;Database=TestTaskDB;User=root;Password=P@ssw0rd;";
                        db.Driver<NHibernate.Driver.MySqlDataDriver>();
                        db.Dialect<NHibernate.Dialect.MySQL55Dialect>();
                        db.SchemaAction = SchemaAutoAction.Update;
                    });

                    
                    HbmSerializer.Default.Validate = true;
                    var stream = HbmSerializer.Default.Serialize(Assembly.GetExecutingAssembly());
                    configuration.AddInputStream(stream);

                    _sessionFactory = configuration.BuildSessionFactory();
                }
                return _sessionFactory;
            }
        }

        public static ISession OpenSession() => SessionFactory.OpenSession();
    }
}