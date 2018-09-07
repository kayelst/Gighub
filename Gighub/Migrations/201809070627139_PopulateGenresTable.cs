namespace Gighub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Jazz')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Nightcore')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Trance')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Rock')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (5, 'Country')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (6, 'Blues')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Genres WHERE Id IS (1, 2, 3, 4)");
        }
    }
}
