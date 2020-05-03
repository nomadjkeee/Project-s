namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitCustomerTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Birthhday", c => c.DateTime(nullable: false));
            AddColumn("dbo.Customers", "Email", c => c.String(maxLength: 255));
            AlterColumn("dbo.Customers", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Name", c => c.String());
            DropColumn("dbo.Customers", "Email");
            DropColumn("dbo.Customers", "Birthhday");
        }
    }
}
