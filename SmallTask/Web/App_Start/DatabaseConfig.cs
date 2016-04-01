namespace SmallTask.Web.App_Start
{
    using System.Data.Entity;
    using SmallTask.Data;
    using SmallTask.Data.Migrations;

    public class DatabaseConfig
    {
        public static void Initialize()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SmallTaskDbContext, Configuration>());
            SmallTaskDbContext.Create().Database.Initialize(true);
        }
    }
}