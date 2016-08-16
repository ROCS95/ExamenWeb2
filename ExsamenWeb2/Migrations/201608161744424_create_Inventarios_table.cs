namespace ExamenWeb2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_Inventarios_table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Inventarios",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Producto = c.String(),
                        Catidad = c.Int(nullable: false),
                        CatidadMinima = c.Int(nullable: false),
                        CatidadMaxima = c.Int(nullable: false),
                        GrabadoExcepto = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Inventarios");
        }
    }
}
