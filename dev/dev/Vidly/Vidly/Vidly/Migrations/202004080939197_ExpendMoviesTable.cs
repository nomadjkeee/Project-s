namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ExpendMoviesTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "GenreId", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "Movies_Id", c => c.Int());
            AddColumn("dbo.Movies", "GenreId", c => c.Int(nullable: false));
            CreateIndex("dbo.Customers", "GenreId");
            CreateIndex("dbo.Customers", "Movies_Id");
            CreateIndex("dbo.Movies", "GenreId");
            AddForeignKey("dbo.Customers", "GenreId", "dbo.Genres", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Customers", "Movies_Id", "dbo.Movies", "Id");
            AddForeignKey("dbo.Movies", "GenreId", "dbo.Genres", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "GenreId", "dbo.Genres");
            DropForeignKey("dbo.Customers", "Movies_Id", "dbo.Movies");
            DropForeignKey("dbo.Customers", "GenreId", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "GenreId" });
            DropIndex("dbo.Customers", new[] { "Movies_Id" });
            DropIndex("dbo.Customers", new[] { "GenreId" });
            DropColumn("dbo.Movies", "GenreId");
            DropColumn("dbo.Customers", "Movies_Id");
            DropColumn("dbo.Customers", "GenreId");
        }
    }
}
