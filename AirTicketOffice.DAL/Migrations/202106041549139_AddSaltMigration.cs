namespace AirTicketOffice.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSaltMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AirportEntities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        City = c.String(),
                        Image = c.String(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RouteEntities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        From = c.String(),
                        To = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        AirportId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AirportEntities", t => t.AirportId, cascadeDelete: true)
                .Index(t => t.AirportId);
            
            CreateTable(
                "dbo.FlightEntities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateTo = c.DateTime(nullable: false),
                        DateFrom = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        PlaneId = c.Int(),
                        RouteId = c.Int(),
                        OrderId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.OrderEntities", t => t.OrderId)
                .ForeignKey("dbo.PlaneEntities", t => t.PlaneId)
                .ForeignKey("dbo.RouteEntities", t => t.RouteId)
                .Index(t => t.PlaneId)
                .Index(t => t.RouteId)
                .Index(t => t.OrderId);
            
            CreateTable(
                "dbo.OrderEntities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DesiredDate = c.DateTime(nullable: false),
                        OrderDate = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        UserId = c.Int(),
                        OfficeId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.OfficeEntities", t => t.OfficeId)
                .ForeignKey("dbo.UserEntities", t => t.UserId)
                .Index(t => t.UserId)
                .Index(t => t.OfficeId);
            
            CreateTable(
                "dbo.OfficeEntities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Number = c.Int(nullable: false),
                        Image = c.String(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserEntities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Login = c.String(),
                        HashedPassword = c.String(),
                        Salt = c.String(),
                        Proxy = c.Boolean(nullable: false),
                        Surname = c.String(),
                        Name = c.String(),
                        Patronymic = c.String(),
                        Gender = c.String(),
                        PassportNumber = c.String(),
                        PhoneNumber = c.String(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TicketEntities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Class = c.String(),
                        Cost = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        FlightId = c.Int(nullable: false),
                        UserId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FlightEntities", t => t.FlightId, cascadeDelete: true)
                .ForeignKey("dbo.UserEntities", t => t.UserId)
                .Index(t => t.FlightId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.PlaneEntities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Number = c.Int(nullable: false),
                        Type = c.String(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CrewMemberEntities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Initials = c.String(),
                        Position = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        PlaneId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PlaneEntities", t => t.PlaneId)
                .Index(t => t.PlaneId);
            
            CreateTable(
                "dbo.EventEntities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Image = c.String(),
                        Description = c.String(),
                        EndingDate = c.DateTime(nullable: false),
                        Position = c.String(),
                        Status = c.String(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FlightEntities", "RouteId", "dbo.RouteEntities");
            DropForeignKey("dbo.FlightEntities", "PlaneId", "dbo.PlaneEntities");
            DropForeignKey("dbo.CrewMemberEntities", "PlaneId", "dbo.PlaneEntities");
            DropForeignKey("dbo.TicketEntities", "UserId", "dbo.UserEntities");
            DropForeignKey("dbo.TicketEntities", "FlightId", "dbo.FlightEntities");
            DropForeignKey("dbo.OrderEntities", "UserId", "dbo.UserEntities");
            DropForeignKey("dbo.OrderEntities", "OfficeId", "dbo.OfficeEntities");
            DropForeignKey("dbo.FlightEntities", "OrderId", "dbo.OrderEntities");
            DropForeignKey("dbo.RouteEntities", "AirportId", "dbo.AirportEntities");
            DropIndex("dbo.CrewMemberEntities", new[] { "PlaneId" });
            DropIndex("dbo.TicketEntities", new[] { "UserId" });
            DropIndex("dbo.TicketEntities", new[] { "FlightId" });
            DropIndex("dbo.OrderEntities", new[] { "OfficeId" });
            DropIndex("dbo.OrderEntities", new[] { "UserId" });
            DropIndex("dbo.FlightEntities", new[] { "OrderId" });
            DropIndex("dbo.FlightEntities", new[] { "RouteId" });
            DropIndex("dbo.FlightEntities", new[] { "PlaneId" });
            DropIndex("dbo.RouteEntities", new[] { "AirportId" });
            DropTable("dbo.EventEntities");
            DropTable("dbo.CrewMemberEntities");
            DropTable("dbo.PlaneEntities");
            DropTable("dbo.TicketEntities");
            DropTable("dbo.UserEntities");
            DropTable("dbo.OfficeEntities");
            DropTable("dbo.OrderEntities");
            DropTable("dbo.FlightEntities");
            DropTable("dbo.RouteEntities");
            DropTable("dbo.AirportEntities");
        }
    }
}
