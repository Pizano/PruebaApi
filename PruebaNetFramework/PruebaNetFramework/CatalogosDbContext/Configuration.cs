namespace PruebaNetFramework.CatalogosDbContext
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class CatalogosDbContext : DbMigrationsConfiguration<PruebaNetFramework.Data.CatalogosDbContext>
    {
        public CatalogosDbContext()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"CatalogosDbContext";
        }

        protected override void Seed(PruebaNetFramework.Data.CatalogosDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
