namespace logisticTracker.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedTripEntity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Trips",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        VehicleNo = c.String(),
                        loadingDate = c.DateTime(nullable: false),
                        KarachiRent = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Details = c.String(),
                        Weight = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Trips");
        }
    }
}
