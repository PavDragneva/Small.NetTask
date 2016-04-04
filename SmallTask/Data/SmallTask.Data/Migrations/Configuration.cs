namespace SmallTask.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

   public sealed class Configuration : DbMigrationsConfiguration<SmallTask.Data.SmallTaskDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(SmallTaskDbContext context)
        {
            var seed = new SeedDb();
            seed.Start(context);
        }
    }
}
