namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBirthDateOfOneCustomer : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET BirthDate = '10/06/1995' WHERE Id = 1");
        }
        
        public override void Down()
        {
        }
    }
}
