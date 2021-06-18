namespace AirTicketOffice.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTicketPrices : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TicketEntities", "FlightId", "dbo.FlightEntities");
            DropForeignKey("dbo.TicketEntities", "ClassId", "dbo.ClassEntities");
            DropIndex("dbo.TicketEntities", new[] { "FlightId" });
            DropIndex("dbo.TicketEntities", new[] { "ClassId" });
            RenameColumn(table: "dbo.TicketEntities", name: "FlightId", newName: "FlightEntity_Id");
            RenameColumn(table: "dbo.TicketEntities", name: "ClassId", newName: "ClassEntity_Id");
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
                .ForeignKey("dbo.ClassEntities", t => t.FlightId, cascadeDelete: true)
                .Index(t => t.ClassId)
                .Index(t => t.FlightId);
            
            AddColumn("dbo.TicketEntities", "TicketPriceId", c => c.Int(nullable: false));
            AlterColumn("dbo.TicketEntities", "FlightEntity_Id", c => c.Int());
            AlterColumn("dbo.TicketEntities", "ClassEntity_Id", c => c.Int());
            CreateIndex("dbo.TicketEntities", "TicketPriceId");
            CreateIndex("dbo.TicketEntities", "ClassEntity_Id");
            CreateIndex("dbo.TicketEntities", "FlightEntity_Id");
            AddForeignKey("dbo.TicketEntities", "TicketPriceId", "dbo.TicketPriceEntities", "Id", cascadeDelete: true);
            AddForeignKey("dbo.TicketEntities", "FlightEntity_Id", "dbo.FlightEntities", "Id");
            AddForeignKey("dbo.TicketEntities", "ClassEntity_Id", "dbo.ClassEntities", "Id");
            DropColumn("dbo.TicketEntities", "Cost");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TicketEntities", "Cost", c => c.Int(nullable: false));
            DropForeignKey("dbo.TicketEntities", "ClassEntity_Id", "dbo.ClassEntities");
            DropForeignKey("dbo.TicketEntities", "FlightEntity_Id", "dbo.FlightEntities");
            DropForeignKey("dbo.TicketEntities", "TicketPriceId", "dbo.TicketPriceEntities");
            DropForeignKey("dbo.TicketPriceEntities", "FlightId", "dbo.ClassEntities");
            DropForeignKey("dbo.TicketPriceEntities", "ClassId", "dbo.ClassEntities");
            DropIndex("dbo.TicketPriceEntities", new[] { "FlightId" });
            DropIndex("dbo.TicketPriceEntities", new[] { "ClassId" });
            DropIndex("dbo.TicketEntities", new[] { "FlightEntity_Id" });
            DropIndex("dbo.TicketEntities", new[] { "ClassEntity_Id" });
            DropIndex("dbo.TicketEntities", new[] { "TicketPriceId" });
            AlterColumn("dbo.TicketEntities", "ClassEntity_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.TicketEntities", "FlightEntity_Id", c => c.Int(nullable: false));
            DropColumn("dbo.TicketEntities", "TicketPriceId");
            DropTable("dbo.TicketPriceEntities");
            RenameColumn(table: "dbo.TicketEntities", name: "ClassEntity_Id", newName: "ClassId");
            RenameColumn(table: "dbo.TicketEntities", name: "FlightEntity_Id", newName: "FlightId");
            CreateIndex("dbo.TicketEntities", "ClassId");
            CreateIndex("dbo.TicketEntities", "FlightId");
            AddForeignKey("dbo.TicketEntities", "ClassId", "dbo.ClassEntities", "Id", cascadeDelete: true);
            AddForeignKey("dbo.TicketEntities", "FlightId", "dbo.FlightEntities", "Id", cascadeDelete: true);
        }
    }
}
