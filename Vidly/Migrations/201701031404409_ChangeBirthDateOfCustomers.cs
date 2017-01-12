namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeBirthDateOfCustomers : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET BirthDate = '10/06/1995' WHERE Id = 1");
            Sql("UPDATE Customers SET BirthDate = '' WHERE Id = 2");
        }
        
        public override void Down()
        {
        }
    }
}
