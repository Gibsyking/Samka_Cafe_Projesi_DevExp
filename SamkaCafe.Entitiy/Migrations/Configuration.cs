namespace SamkaCafe.Entitiy.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    //internal
    internal sealed class Configuration : DbMigrationsConfiguration<SamkaCafe.Entitiy.Models.CafeContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed= true;
        }

        protected override void Seed(SamkaCafe.Entitiy.Models.CafeContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
