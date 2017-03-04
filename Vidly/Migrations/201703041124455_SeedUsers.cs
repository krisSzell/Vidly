namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'472927a0-73c5-4679-9239-d7df6a2033d4', N'guest@vidly.com', 0, N'AKBosrIMJvfG5YFSRkgyc+HEIGNaMZHd5SlSqgFsHGrK4rRTnnNY1tH4hoG8Qo5YWA==', N'74dd5ac5-6a65-4ba2-a0f5-74e217415019', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                  INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'7e5440ec-0965-44df-9b81-f18da4ff4c3d', N'admin@vidly.com', 0, N'AGoct0HxeS72WoTzS8Fh99s8sItFhMFttxtwXSZY5gmxMlXCHLzOk6cH8FhnB4wNWw==', N'190497b7-fc51-4070-b831-076b64d7c20e', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                  INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'b41bf196-a6e8-4f73-ace9-276e54d431a9', N'CanManageMovies')
                  INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'7e5440ec-0965-44df-9b81-f18da4ff4c3d', N'b41bf196-a6e8-4f73-ace9-276e54d431a9')
                  ");
        }
        
        public override void Down()
        {
        }
    }
}
