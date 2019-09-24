namespace PruebaNetFramework.InventarioDbContext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Articulo",
                c => new
                    {
                        Sku_ID = c.Int(nullable: false, identity: true),
                        Sku_NumeroSerie = c.String(),
                        Sku_Descripcion = c.String(),
                        Sku_Cantidad = c.String(),
                        Sku_Cat_ID = c.Int(nullable: false),
                        Sku_Sub_Cat_ID = c.Int(nullable: false),
                        Sku_Latitud = c.String(),
                        Sku_Longitud = c.String(),
                    })
                .PrimaryKey(t => t.Sku_ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Articulo");
        }
    }
}
