namespace AirTicketOffice.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RejoinFlightsAndOrders : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.FlightEntities", "OrderId", "dbo.OrderEntities");
            DropForeignKey("dbo.FlightEntities", "RouteId", "dbo.RouteEntities");
            DropForeignKey("dbo.FlightEntities", "PlaneId", "dbo.PlaneEntities");
            DropForeignKey("dbo.OrderEntities", "OfficeId", "dbo.OfficeEntities");
            DropForeignKey("dbo.OrderEntities", "UserId", "dbo.UserEntities");
            DropForeignKey("dbo.CrewMemberEntities", "PlaneId", "dbo.PlaneEntities");
            DropIndex("dbo.FlightEntities", new[] { "PlaneId" });
            DropIndex("dbo.FlightEntities", new[] { "RouteId" });
            DropIndex("dbo.FlightEntities", new[] { "OrderId" });
            DropIndex("dbo.OrderEntities", new[] { "UserId" });
            DropIndex("dbo.OrderEntities", new[] { "OfficeId" });
            DropIndex("dbo.CrewMemberEntities", new[] { "PlaneId" });
            AddColumn("dbo.OrderEntities", "FlightId", c => c.Int(nullable: false));
            AlterColumn("dbo.FlightEntities", "PlaneId", c => c.Int(nullable: false));
            AlterColumn("dbo.FlightEntities", "RouteId", c => c.Int(nullable: false));
            AlterColumn("dbo.OrderEntities", "UserId", c => c.Int(nullable: false));
            AlterColumn("dbo.OrderEntities", "OfficeId", c => c.Int(nullable: false));
            AlterColumn("dbo.CrewMemberEntities", "PlaneId", c => c.Int(nullable: false));
            CreateIndex("dbo.FlightEntities", "PlaneId");
            CreateIndex("dbo.FlightEntities", "RouteId");
            CreateIndex("dbo.OrderEntities", "UserId");
            CreateIndex("dbo.OrderEntities", "OfficeId");
            CreateIndex("dbo.OrderEntities", "FlightId");
            CreateIndex("dbo.CrewMemberEntities", "PlaneId");
            AddForeignKey("dbo.OrderEntities", "FlightId", "dbo.FlightEntities", "Id", cascadeDelete: true);
            AddForeignKey("dbo.FlightEntities", "RouteId", "dbo.RouteEntities", "Id", cascadeDelete: true);
            AddForeignKey("dbo.FlightEntities", "PlaneId", "dbo.PlaneEntities", "Id", cascadeDelete: true);
            AddForeignKey("dbo.OrderEntities", "OfficeId", "dbo.OfficeEntities", "Id", cascadeDelete: true);
            AddForeignKey("dbo.OrderEntities", "UserId", "dbo.UserEntities", "Id", cascadeDelete: true);
            AddForeignKey("dbo.CrewMemberEntities", "PlaneId", "dbo.PlaneEntities", "Id", cascadeDelete: true);
            DropColumn("dbo.FlightEntities", "OrderId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.FlightEntities", "OrderId", c => c.Int());
            DropForeignKey("dbo.CrewMemberEntities", "PlaneId", "dbo.PlaneEntities");
            DropForeignKey("dbo.OrderEntities", "UserId", "dbo.UserEntities");
            DropForeignKey("dbo.OrderEntities", "OfficeId", "dbo.OfficeEntities");
            DropForeignKey("dbo.FlightEntities", "PlaneId", "dbo.PlaneEntities");
            DropForeignKey("dbo.FlightEntities", "RouteId", "dbo.RouteEntities");
            DropForeignKey("dbo.OrderEntities", "FlightId", "dbo.FlightEntities");
            DropIndex("dbo.CrewMemberEntities", new[] { "PlaneId" });
            DropIndex("dbo.OrderEntities", new[] { "FlightId" });
            DropIndex("dbo.OrderEntities", new[] { "OfficeId" });
            DropIndex("dbo.OrderEntities", new[] { "UserId" });
            DropIndex("dbo.FlightEntities", new[] { "RouteId" });
            DropIndex("dbo.FlightEntities", new[] { "PlaneId" });
            AlterColumn("dbo.CrewMemberEntities", "PlaneId", c => c.Int());
            AlterColumn("dbo.OrderEntities", "OfficeId", c => c.Int());
            AlterColumn("dbo.OrderEntities", "UserId", c => c.Int());
            AlterColumn("dbo.FlightEntities", "RouteId", c => c.Int());
            AlterColumn("dbo.FlightEntities", "PlaneId", c => c.Int());
            DropColumn("dbo.OrderEntities", "FlightId");
            CreateIndex("dbo.CrewMemberEntities", "PlaneId");
            CreateIndex("dbo.OrderEntities", "OfficeId");
            CreateIndex("dbo.OrderEntities", "UserId");
            CreateIndex("dbo.FlightEntities", "OrderId");
            CreateIndex("dbo.FlightEntities", "RouteId");
            CreateIndex("dbo.FlightEntities", "PlaneId");
            AddForeignKey("dbo.CrewMemberEntities", "PlaneId", "dbo.PlaneEntities", "Id");
            AddForeignKey("dbo.OrderEntities", "UserId", "dbo.UserEntities", "Id");
            AddForeignKey("dbo.OrderEntities", "OfficeId", "dbo.OfficeEntities", "Id");
            AddForeignKey("dbo.FlightEntities", "PlaneId", "dbo.PlaneEntities", "Id");
            AddForeignKey("dbo.FlightEntities", "RouteId", "dbo.RouteEntities", "Id");
            AddForeignKey("dbo.FlightEntities", "OrderId", "dbo.OrderEntities", "Id");
        }
    }
}
