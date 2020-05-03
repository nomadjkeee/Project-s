namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeCustomerAttribute : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "GenreId", "dbo.Genres");
            DropIndex("dbo.Customers", new[] { "GenreId" });
            AlterColumn("dbo.Customers", "GenreId", c => c.Int());
            CreateIndex("dbo.Customers", "GenreId");
            AddForeignKey("dbo.Customers", "GenreId", "dbo.Genres", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "GenreId", "dbo.Genres");
            DropIndex("dbo.Customers", new[] { "GenreId" });
            AlterColumn("dbo.Customers", "GenreId", c => c.Int(nullable: false));
            CreateIndex("dbo.Customers", "GenreId");
            AddForeignKey("dbo.Customers", "GenreId", "dbo.Genres", "Id", cascadeDelete: true);
        }
    }
}
