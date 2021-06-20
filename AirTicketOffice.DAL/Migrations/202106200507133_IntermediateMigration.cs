namespace AirTicketOffice.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IntermediateMigration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TicketEntities", "ClassId", "dbo.ClassEntities");
            DropForeignKey("dbo.TicketEntities", "FlightId", "dbo.FlightEntities");
            DropIndex("dbo.TicketEntities", new[] { "FlightId" });
            DropIndex("dbo.TicketEntities", new[] { "ClassId" });
            CreateTable(
                "dbo.TicketPriceEntities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Price = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        ClassId = c.Int(nullable: false),
                        FlightId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ClassEntities", t => t.ClassId, cascadeDelete: true)
                .ForeignKey("dbo.FlightEntities", t => t.FlightId, cascadeDelete: true)
                .Index(t => t.ClassId)
                .Index(t => t.FlightId);
            
            AddColumn("dbo.TicketEntities", "TicketPriceId", c => c.Int());
            CreateIndex("dbo.TicketEntities", "TicketPriceId");
            AddForeignKey("dbo.TicketEntities", "TicketPriceId", "dbo.TicketPriceEntities", "Id");
            DropColumn("dbo.TicketEntities", "Cost");
            DropColumn("dbo.TicketEntities", "FlightId");
            DropColumn("dbo.TicketEntities", "ClassId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TicketEntities", "ClassId", c => c.Int(nullable: false));
            AddColumn("dbo.TicketEntities", "FlightId", c => c.Int(nullable: false));
            AddColumn("dbo.TicketEntities", "Cost", c => c.Int(nullable: false));
            DropForeignKey("dbo.TicketEntities", "TicketPriceId", "dbo.TicketPriceEntities");
            DropForeignKey("dbo.TicketPriceEntities", "FlightId", "dbo.FlightEntities");
            DropForeignKey("dbo.TicketPriceEntities", "ClassId", "dbo.ClassEntities");
            DropIndex("dbo.TicketPriceEntities", new[] { "FlightId" });
            DropIndex("dbo.TicketPriceEntities", new[] { "ClassId" });
            DropIndex("dbo.TicketEntities", new[] { "TicketPriceId" });
            DropColumn("dbo.TicketEntities", "TicketPriceId");
            DropTable("dbo.TicketPriceEntities");
            CreateIndex("dbo.TicketEntities", "ClassId");
            CreateIndex("dbo.TicketEntities", "FlightId");
            AddForeignKey("dbo.TicketEntities", "FlightId", "dbo.FlightEntities", "Id", cascadeDelete: true);
            AddForeignKey("dbo.TicketEntities", "ClassId", "dbo.ClassEntities", "Id", cascadeDelete: true);
        }
    }
}
