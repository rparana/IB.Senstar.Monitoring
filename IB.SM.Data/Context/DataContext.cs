using System;
using System.Data.Entity;
using IB.SM.Model.Entities;
using System.Data.Entity.Infrastructure;
using System.Data.SqlServerCe;
using System.Data.Entity.Core.EntityClient;
using IB.IniFile;
using System.IO;
using System.Data.SqlClient;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace IB.SM.Data.Context
{
    public class DataContext : DbContext
    {
        private string _metaData, _dataSource, _initialCatalog;
        private static string _providerName;
        // Entities to map
        public DbSet<SenstarEvents> SenstarEvents { get; set; }
        public DbSet<LogFile> LogFiles { get; set; }
        public DbSet<Central> Centrais { get; set; }
        public DbSet<Grupo> Grupos { get; set; }
        public DbSet<Permissao> Permissoes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Zone> Zonas { get; set; }
        public DbSet<ConfigSys> Configuracoes { get; set; }


        public DataContext() : base(GetConnection())
        {
            Database.DefaultConnectionFactory = new SqlCeConnectionFactory(_providerName);
            //Database.CreateIfNotExists();
            Database.SetInitializer<DataContext>(new MigrateDatabaseToLatestVersion<DataContext, Migrations.Configuration>());
            //if (!base.Database.Exists())
            //    base.Database.CreateIfNotExists();

        }
        //public DataContext() : base("DataContext")
        //{
        //    //Database.DefaultConnectionFactory = new SqlCeConnectionFactory(_providerName);
        //    //Database.CreateIfNotExists();
        //}

        private void CreateDataBase(Database database)
        {
            if (!database.Exists())
                database.Create();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            //modelBuilder.Entity<Usuario>()
            //    .HasOptional<Grupo>(s => s.Grupo)
            //    .WithMany()
            //    .WillCascadeOnDelete(false);
        }

        private static string GetConnection()
        {
            const string appName = "EntityFramework";
            string retorno = "";

            string executable = AppDomain.CurrentDomain.BaseDirectory;
            string path = (Path.GetDirectoryName(executable));
            EntityConnectionStringBuilder efBuilder = new EntityConnectionStringBuilder();
            INIFile INI = new INIFile(Path.Combine(path, "IBConfig.ini"));

            _providerName = INI.IniReadValue("DataBase", "providerName");
            if (_providerName == "System.Data.SqlServerCe.4.0")
            {
                SqlCeConnectionStringBuilder sqlBuilder = new SqlCeConnectionStringBuilder();
                sqlBuilder.DataSource = INI.IniReadValue("DataBase", "dataSource");
                sqlBuilder.Password = INI.IniReadValue("DataBase", "password");
                retorno = sqlBuilder.ConnectionString;
            }
            else
            {
                SqlConnectionStringBuilder sqlBuilder = new SqlConnectionStringBuilder();
                sqlBuilder.DataSource = INI.IniReadValue("DataBase", "dataSource");
                sqlBuilder.IntegratedSecurity = false;
                sqlBuilder.InitialCatalog = INI.IniReadValue("DataBase", "InitialCatalog");
                sqlBuilder.UserID = INI.IniReadValue("DataBase", "user");
                sqlBuilder.Password = INI.IniReadValue("DataBase", "password");
                retorno = sqlBuilder.ConnectionString;
            }
            //efBuilder.Metadata = metaData;
            efBuilder.Provider = _providerName;
            string s = efBuilder.ToString();
            return retorno;
        }

        public static string CreateConnectionString()
        {
            string metaData = String.Empty;
            string dataSource = String.Empty;
            string initialCatalog = String.Empty;
            string providerName = String.Empty;
            return CreateConnectionString(providerName, dataSource, initialCatalog, "", "SuporteIB");
        }
        public static string CreateConnectionString(string providerName, string dataSource, string initialCatalog, string user, string password)
        {

            const string appName = "EntityFramework";

            SqlConnectionStringBuilder sqlBuilder = new SqlConnectionStringBuilder();
            sqlBuilder.DataSource = dataSource;
            sqlBuilder.InitialCatalog = initialCatalog;
            sqlBuilder.ApplicationName = appName;
            sqlBuilder.UserID = user;
            sqlBuilder.Password = password;

            EntityConnectionStringBuilder efBuilder = new EntityConnectionStringBuilder();
            //efBuilder.Metadata = metaData;
            efBuilder.Provider = providerName;
            efBuilder.ProviderConnectionString = sqlBuilder.ConnectionString;

            return efBuilder.ConnectionString;
        }
    }
}
