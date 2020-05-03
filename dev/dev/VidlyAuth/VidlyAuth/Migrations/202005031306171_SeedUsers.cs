namespace VidlyAuth.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9d8eb00b-7efa-4c36-8412-862a9fc3fb5f', N'nomad9965@gmail.com', 0, N'ADMgduLA1fZ2v66zBlEz891xCUj81hMkJx8DqIVdPxOOQo9Lj1hVBATpxjxS1mizAA==', N'dfbdb973-5b62-4530-8e4d-c276a0ef3d43', NULL, 0, 0, NULL, 1, 0, N'nomad9965@gmail.com')
            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'506f6ab5-8131-4fcf-a6f3-e0c9f5884c23', N'CanManage')
            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'9d8eb00b-7efa-4c36-8412-862a9fc3fb5f', N'506f6ab5-8131-4fcf-a6f3-e0c9f5884c23')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
