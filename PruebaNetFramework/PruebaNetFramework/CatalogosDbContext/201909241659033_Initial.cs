namespace PruebaNetFramework.CatalogosDbContext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        Cat_ID = c.Int(nullable: false, identity: true),
                        Cat_CodCategoria = c.Int(nullable: false),
                        Cat_Cat_Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Cat_ID);
            
            CreateTable(
                "dbo.SubCategorias",
                c => new
                    {
                        SubCat_ID = c.Int(nullable: false, identity: true),
                        SubCat_Cat_ID = c.Int(nullable: false),
                        SubCat_SubCatCodigo = c.Int(nullable: false),
                        SubCat_Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.SubCat_ID)
                .ForeignKey("dbo.Categorias", t => t.SubCat_Cat_ID, cascadeDelete: true)
                .Index(t => t.SubCat_Cat_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SubCategorias", "SubCat_Cat_ID", "dbo.Categorias");
            DropIndex("dbo.SubCategorias", new[] { "SubCat_Cat_ID" });
            DropTable("dbo.SubCategorias");
            DropTable("dbo.Categorias");
        }
    }
}
