namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitMemberShipTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "MemberShipId", "dbo.MemberShips");
            DropIndex("dbo.Customers", new[] { "MemberShipId" });
            AddColumn("dbo.MemberShips", "PercentCount", c => c.Short(nullable: false));
            AlterColumn("dbo.Customers", "MemberShipId", c => c.Int(nullable: false));
            CreateIndex("dbo.Customers", "MemberShipId");
            AddForeignKey("dbo.Customers", "MemberShipId", "dbo.MemberShips", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "MemberShipId", "dbo.MemberShips");
            DropIndex("dbo.Customers", new[] { "MemberShipId" });
            AlterColumn("dbo.Customers", "MemberShipId", c => c.Int());
            DropColumn("dbo.MemberShips", "PercentCount");
            CreateIndex("dbo.Customers", "MemberShipId");
            AddForeignKey("dbo.Customers", "MemberShipId", "dbo.MemberShips", "Id");
        }
    }
}
