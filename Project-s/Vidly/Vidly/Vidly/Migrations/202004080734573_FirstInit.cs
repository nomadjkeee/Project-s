namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstInit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Year = c.Short(nullable: false),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.Id);
           ///this.Sql("Insert into Customers (Name) values('gena')");
        }
        
        public override void Down()
        {
            DropTable("dbo.Movies");
            DropTable("dbo.Customers");
        }
    }
}
