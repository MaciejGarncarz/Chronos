namespace Chronos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PlanAndReccurencePlan : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Plans",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        RenewalDate = c.DateTime(nullable: false),
                        ExpectedBudget = c.Decimal(precision: 18, scale: 2),
                        RecurrencePlanId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.RecurrencePlans", t => t.RecurrencePlanId, cascadeDelete: true)
                .Index(t => t.RecurrencePlanId);
            
            CreateTable(
                "dbo.RecurrencePlans",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Plans", "RecurrencePlanId", "dbo.RecurrencePlans");
            DropIndex("dbo.Plans", new[] { "RecurrencePlanId" });
            DropTable("dbo.RecurrencePlans");
            DropTable("dbo.Plans");
        }
    }
}
