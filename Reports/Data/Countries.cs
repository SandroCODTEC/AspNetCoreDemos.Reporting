using System.Data.Common;
using System.Data.SQLite;
using System.IO;
using DevExpress.Internal;
using Microsoft.EntityFrameworkCore;

namespace DevExpress.DemoData.Models {
    //public class CountriesEntities : DbContext {
    //    public CountriesEntities() : base(CreateConnection(GenerateConnectionString()), contextOwnsConnection: true) { }

    //    public CountriesEntities(string connectionString) : base(CreateConnection(connectionString), contextOwnsConnection: true) { }
    //    public CountriesEntities(DbConnection connection) : base(connection, true) { }

    //    static CountriesEntities() {
    //        Database.SetInitializer<CountriesEntities>(null);
    //    }

    //    protected override void OnModelCreating(ModelBuilder modelBuilder) {
    //         modelBuilder.Entity<AboutRegion>();
    //         modelBuilder.Entity<Hierarchy>();
    //    }

    //    static DbConnection CreateConnection(string connectionString) {
    //        var connection = Microsoft.Data.Sqlite.SqliteFactory.Instance.CreateConnection();
    //        connection.ConnectionString = connectionString;
    //        return connection;
    //    }

    //    static string filePath;
    //    static string GenerateConnectionString() {
    //        if(filePath == null)
    //            filePath = DataDirectoryHelper.GetFile("countries.db", DataDirectoryHelper.DataFolderName);
    //        try {
    //            var attributes = File.GetAttributes(filePath);
    //            if(attributes.HasFlag(FileAttributes.ReadOnly)) {
    //                File.SetAttributes(filePath, attributes & ~FileAttributes.ReadOnly);
    //            }
    //        } catch { }
    //        return new SQLiteConnectionStringBuilder { DataSource = filePath }.ConnectionString;
    //    }

    //    public virtual DbQuery<AboutRegion> AboutRegions { get { return Set<AboutRegion>().AsNoTracking(); } }
    //    public virtual DbQuery<Hierarchy> Hierarchy { get { return Set<Hierarchy>().AsNoTracking(); } }
    //}
}
