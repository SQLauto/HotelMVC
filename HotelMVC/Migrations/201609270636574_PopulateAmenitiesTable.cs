namespace HotelMVC.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateAmenitiesTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Amenities (Name) VALUES ('Refrigerator')");
            Sql("INSERT INTO Amenities (Name) VALUES ('Mini-Fridge')");
            Sql("INSERT INTO Amenities (Name) VALUES ('Television')");
            Sql("INSERT INTO Amenities (Name) VALUES ('Microwave')");
            Sql("INSERT INTO Amenities (Name) VALUES ('Dresser')");
            Sql("INSERT INTO Amenities (Name) VALUES ('Table')");
            Sql("INSERT INTO Amenities (Name) VALUES ('Private Entrance')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Amenities WHERE Id IN (1, 2, 3, 4, 5, 6, 7)");
        }
    }
}
