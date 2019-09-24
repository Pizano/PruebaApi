namespace PruebaNetFramework.InventarioDbContext
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class InventarioDbContext : DbMigrationsConfiguration<PruebaNetFramework.Data.InventarioDbContext>
    {
        public InventarioDbContext()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"InventarioDbContext";
        }

        protected override void Seed(PruebaNetFramework.Data.InventarioDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
