namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMemberShipKey : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MemberShips",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MemberShipType = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Customers", "MemberShipId", c => c.Int());
            CreateIndex("dbo.Customers", "MemberShipId");
            AddForeignKey("dbo.Customers", "MemberShipId", "dbo.MemberShips", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "MemberShipId", "dbo.MemberShips");
            DropIndex("dbo.Customers", new[] { "MemberShipId" });
            DropColumn("dbo.Customers", "MemberShipId");
            DropTable("dbo.MemberShips");
        }
    }
}
