namespace auth.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'6aaa79fd-7ebf-493e-964f-1d70f652992f', N'c@gmail.com', 0, N'AHTPQ5Jh56ltwmJmUNn2Gb5ReKgg2Behtp7N8cV0biej+65F8bMat94mH6dmG46i5Q==', N'441bebe2-192d-4473-aac4-885f379e2191', NULL, 0, 0, NULL, 1, 0, N'c@gmail.com')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'cf8b4bf4-86bd-46df-8c52-e22a0e06d7f3', N'admin@auth.com', 0, N'AIA/8oPpNC8+r26Ji71UBXugt7Z2oThEpjQtHxZB45v/4aFzM28jVL/e1ztwRKzCRg==', N'2dbfa496-7c85-460a-88fa-1419699a46c9', NULL, 0, 0, NULL, 1, 0, N'admin@auth.com')
            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'f12830c8-e6a7-4d36-8229-3cd47cfd7ed4', N'CanManageMovie')
            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'cf8b4bf4-86bd-46df-8c52-e22a0e06d7f3', N'f12830c8-e6a7-4d36-8229-3cd47cfd7ed4')

            ");
        }
        
        public override void Down()
        {
        }
    }
}
