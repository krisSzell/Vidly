namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPhoneToUserModel : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE dbo.AspNetUsers SET PhoneNumber='794002124' WHERE Email='skorupa.krzysztof1@gmail.com'");
            Sql("UPDATE dbo.AspNetUsers SET PhoneNumber='606665641' WHERE Email='admin@vidly.com'");
            Sql("UPDATE dbo.AspNetUsers SET PhoneNumber='231457654' WHERE Email='guest@vidly.com'");
        }
        
        public override void Down()
        {
        }
    }
}
