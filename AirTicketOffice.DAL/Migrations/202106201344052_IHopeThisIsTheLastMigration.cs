namespace AirTicketOffice.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IHopeThisIsTheLastMigration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TicketEntities", "TicketPriceId", "dbo.TicketPriceEntities");
            DropIndex("dbo.TicketEntities", new[] { "TicketPriceId" });
            AddColumn("dbo.TicketEntities", "OrderDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TicketEntities", "TicketPriceId", c => c.Int(nullable: false));
            CreateIndex("dbo.TicketEntities", "TicketPriceId");
            AddForeignKey("dbo.TicketEntities", "TicketPriceId", "dbo.TicketPriceEntities", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TicketEntities", "TicketPriceId", "dbo.TicketPriceEntities");
            DropIndex("dbo.TicketEntities", new[] { "TicketPriceId" });
            AlterColumn("dbo.TicketEntities", "TicketPriceId", c => c.Int());
            DropColumn("dbo.TicketEntities", "OrderDate");
            CreateIndex("dbo.TicketEntities", "TicketPriceId");
            AddForeignKey("dbo.TicketEntities", "TicketPriceId", "dbo.TicketPriceEntities", "Id");
        }
    }
}
