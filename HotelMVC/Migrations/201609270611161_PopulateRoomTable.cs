namespace HotelMVC.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateRoomTable : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Amenities", name: "Room_Id", newName: "Rooms_Id");
            RenameIndex(table: "dbo.Amenities", name: "IX_Room_Id", newName: "IX_Rooms_Id");
            DropColumn("dbo.Amenities", "Description");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Amenities", "Description", c => c.String(nullable: false, maxLength: 1500));
            RenameIndex(table: "dbo.Amenities", name: "IX_Rooms_Id", newName: "IX_Room_Id");
            RenameColumn(table: "dbo.Amenities", name: "Rooms_Id", newName: "Room_Id");
        }
    }
}
