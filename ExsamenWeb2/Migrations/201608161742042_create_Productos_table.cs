namespace ExamenWeb2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_Productos_table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Productoes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Marca = c.String(),
                        Familia = c.String(),
                        CasaFabricacion = c.String(),
                        TipoUmidad = c.String(),
                        Departamento = c.String(),
                        Activo = c.String(),
                        FechaIngreso = c.String(),
                        Unidad = c.String(),
                        Impuesto = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Productoes");
        }
    }
}
