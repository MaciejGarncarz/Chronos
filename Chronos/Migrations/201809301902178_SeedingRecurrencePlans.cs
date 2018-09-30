namespace Chronos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedingRecurrencePlans : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO RecurrencePlans (Name) VALUES('One month')");
            Sql("INSERT INTO RecurrencePlans (Name) VALUES('Two months')");
            Sql("INSERT INTO RecurrencePlans (Name) VALUES('Three months')");
            Sql("INSERT INTO RecurrencePlans (Name) VALUES('Six months')");
            Sql("INSERT INTO RecurrencePlans (Name) VALUES('Year')");
        }
        
        public override void Down()
        {
        }
    }
}
