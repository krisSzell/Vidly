namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMoviesTable : DbMigration
    {
        public override void Up()
        {
            //Sql("INSERT INTO Movies (Id, Name, GenreId, ReleaseTime, DateAdded, NumberInStock) VALUES (1, 'Hangover', 1, '10/06/2005', '12/12/2014', 6)");
            //Sql("INSERT INTO Movies (Id, Name, GenreId, ReleaseTime, DateAdded, NumberInStock) VALUES (2, 'Die Hard', 2, '10/11/2002', '12/12/2014', 3)");
            //Sql("INSERT INTO Movies (Id, Name, GenreId, ReleaseTime, DateAdded, NumberInStock) VALUES (3, 'The Terminator', 2, '21/06/2010', '12/12/2014', 2)");
            //Sql("INSERT INTO Movies (Id, Name, GenreId, ReleaseTime, DateAdded, NumberInStock) VALUES (4, 'Toy Story', 3, '10/06/2003', '12/12/2014', 1)");
            //Sql("INSERT INTO Movies (Id, Name, GenreId, ReleaseTime, DateAdded, NumberInStock) VALUES (5, 'Titanic', 4, '14/08/2009', '12/12/2014', 5)");
            //Sql("INSERT INTO Movies (Id, Name, GenreId, ReleaseTime, DateAdded, NumberInStock) VALUES (6, 'Deepwater Horizon', 2, '10/06/2005', '12/12/2014', 12)");
        }
        
        public override void Down()
        {
        }
    }
}
