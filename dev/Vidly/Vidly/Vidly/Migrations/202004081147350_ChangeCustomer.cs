namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeCustomer : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Birthhday", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Birthhday", c => c.DateTime(nullable: false));
        }
    }
}
