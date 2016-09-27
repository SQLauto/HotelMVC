namespace HotelMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ConventionsOverrideForRoomAndAmenity : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Amenities", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Amenities", "Description", c => c.String(nullable: false, maxLength: 1500));
            AlterColumn("dbo.Rooms", "Name", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Rooms", "Name", c => c.String());
            AlterColumn("dbo.Amenities", "Description", c => c.String());
            AlterColumn("dbo.Amenities", "Name", c => c.String());
        }
    }
}
