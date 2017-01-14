namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MovieValidationModelUpdate : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET DateAdded='10/15/2014' WHERE Id > 5");
            AlterColumn("dbo.MembershipTypes", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Movies", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Movies", "ReleaseTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Movies", "DateAdded", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "DateAdded", c => c.DateTime());
            AlterColumn("dbo.Movies", "ReleaseTime", c => c.DateTime());
            AlterColumn("dbo.Movies", "Name", c => c.String());
            AlterColumn("dbo.MembershipTypes", "Name", c => c.String());
        }
    }
}
