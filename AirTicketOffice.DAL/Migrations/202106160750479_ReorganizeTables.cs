namespace AirTicketOffice.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReorganizeTables : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TicketEntities", "UserId", "dbo.UserEntities");
            DropForeignKey("dbo.RouteEntities", "AirportId", "dbo.AirportEntities");
            DropIndex("dbo.TicketEntities", new[] { "UserId" });
            RenameColumn(table: "dbo.RouteEntities", name: "AirportId", newName: "ArrivalAirportId");
            RenameIndex(table: "dbo.RouteEntities", name: "IX_AirportId", newName: "IX_ArrivalAirportId");
            CreateTable(
                "dbo.ClassEntities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SeatEntities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Amount = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        PlaneId = c.Int(nullable: false),
                        ClassId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ClassEntities", t => t.ClassId, cascadeDelete: true)
                .ForeignKey("dbo.PlaneEntities", t => t.PlaneId, cascadeDelete: true)
                .Index(t => t.PlaneId)
                .Index(t => t.ClassId);
            
            AddColumn("dbo.RouteEntities", "DepartureAirportId", c => c.Int(nullable: false));
            AddColumn("dbo.TicketEntities", "ClassId", c => c.Int(nullable: false));
            AlterColumn("dbo.TicketEntities", "UserId", c => c.Int(nullable: false));
            CreateIndex("dbo.RouteEntities", "DepartureAirportId");
            CreateIndex("dbo.TicketEntities", "UserId");
            CreateIndex("dbo.TicketEntities", "ClassId");
            AddForeignKey("dbo.RouteEntities", "DepartureAirportId", "dbo.AirportEntities", "Id");
            AddForeignKey("dbo.TicketEntities", "ClassId", "dbo.ClassEntities", "Id", cascadeDelete: true);
            AddForeignKey("dbo.TicketEntities", "UserId", "dbo.UserEntities", "Id", cascadeDelete: true);
            AddForeignKey("dbo.RouteEntities", "ArrivalAirportId", "dbo.AirportEntities", "Id");
            DropColumn("dbo.RouteEntities", "From");
            DropColumn("dbo.RouteEntities", "To");
            DropColumn("dbo.TicketEntities", "Class");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TicketEntities", "Class", c => c.String());
            AddColumn("dbo.RouteEntities", "To", c => c.String());
            AddColumn("dbo.RouteEntities", "From", c => c.String());
            DropForeignKey("dbo.RouteEntities", "ArrivalAirportId", "dbo.AirportEntities");
            DropForeignKey("dbo.TicketEntities", "UserId", "dbo.UserEntities");
            DropForeignKey("dbo.TicketEntities", "ClassId", "dbo.ClassEntities");
            DropForeignKey("dbo.SeatEntities", "PlaneId", "dbo.PlaneEntities");
            DropForeignKey("dbo.SeatEntities", "ClassId", "dbo.ClassEntities");
            DropForeignKey("dbo.RouteEntities", "DepartureAirportId", "dbo.AirportEntities");
            DropIndex("dbo.SeatEntities", new[] { "ClassId" });
            DropIndex("dbo.SeatEntities", new[] { "PlaneId" });
            DropIndex("dbo.TicketEntities", new[] { "ClassId" });
            DropIndex("dbo.TicketEntities", new[] { "UserId" });
            DropIndex("dbo.RouteEntities", new[] { "DepartureAirportId" });
            AlterColumn("dbo.TicketEntities", "UserId", c => c.Int());
            DropColumn("dbo.TicketEntities", "ClassId");
            DropColumn("dbo.RouteEntities", "DepartureAirportId");
            DropTable("dbo.SeatEntities");
            DropTable("dbo.ClassEntities");
            RenameIndex(table: "dbo.RouteEntities", name: "IX_ArrivalAirportId", newName: "IX_AirportId");
            RenameColumn(table: "dbo.RouteEntities", name: "ArrivalAirportId", newName: "AirportId");
            CreateIndex("dbo.TicketEntities", "UserId");
            AddForeignKey("dbo.RouteEntities", "AirportId", "dbo.AirportEntities", "Id", cascadeDelete: true);
            AddForeignKey("dbo.TicketEntities", "UserId", "dbo.UserEntities", "Id");
        }
    }
}
