namespace HotelMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateRoomTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Amenities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Room_Id = c.Byte(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Rooms", t => t.Room_Id)
                .Index(t => t.Room_Id);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Amenities", "Room_Id", "dbo.Rooms");
            DropIndex("dbo.Amenities", new[] { "Room_Id" });
            DropTable("dbo.Rooms");
            DropTable("dbo.Amenities");
        }
    }
}
