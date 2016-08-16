namespace ExamenWeb2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_Facturas_table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Facturas",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ClienteNombre = c.String(),
                        Fecha = c.String(),
                        Detalle = c.String(),
                        SubTotal = c.Double(nullable: false),
                        Impuesto = c.Double(nullable: false),
                        Total = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Facturas");
        }
    }
}
