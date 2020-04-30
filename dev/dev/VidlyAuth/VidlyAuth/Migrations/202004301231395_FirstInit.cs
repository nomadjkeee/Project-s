namespace VidlyAuth.Migrations
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
                        Name = c.String(nullable: false),
                        Birthhday = c.String(),
                        Email = c.String(maxLength: 255),
                        MemberShipId = c.Int(nullable: false),
                        GenreId = c.Int(),
                        Movies_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Genres", t => t.GenreId)
                .ForeignKey("dbo.MemberShips", t => t.MemberShipId, cascadeDelete: true)
                .ForeignKey("dbo.Movies", t => t.Movies_Id)
                .Index(t => t.MemberShipId)
                .Index(t => t.GenreId)
                .Index(t => t.Movies_Id);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GenreType = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MemberShips",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MemberShipType = c.String(nullable: false),
                        PercentCount = c.Short(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Detail = c.String(nullable: false),
                        ReleaseDate = c.Short(nullable: false),
                        GenreId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Genres", t => t.GenreId, cascadeDelete: true)
                .Index(t => t.GenreId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "GenreId", "dbo.Genres");
            DropForeignKey("dbo.Customers", "Movies_Id", "dbo.Movies");
            DropForeignKey("dbo.Customers", "MemberShipId", "dbo.MemberShips");
            DropForeignKey("dbo.Customers", "GenreId", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "GenreId" });
            DropIndex("dbo.Customers", new[] { "Movies_Id" });
            DropIndex("dbo.Customers", new[] { "GenreId" });
            DropIndex("dbo.Customers", new[] { "MemberShipId" });
            DropTable("dbo.Movies");
            DropTable("dbo.MemberShips");
            DropTable("dbo.Genres");
            DropTable("dbo.Customers");
        }
    }
}
