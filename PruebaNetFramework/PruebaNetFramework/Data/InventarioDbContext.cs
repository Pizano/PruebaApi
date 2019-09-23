using PruebaNetFramework.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PruebaNetFramework.Data
{
    public class InventarioDbContext :DbContext
    {
        public InventarioDbContext() : 
          base("BDInventarioEntities")
        {
        }

        public static InventarioDbContext Create()
        {
            return new InventarioDbContext();
        }

        public DbSet<Articulo> Articulo { get; set; }
    }
}