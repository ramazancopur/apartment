namespace Apartment.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Hirers", "FlatID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Hirers", "FlatID", c => c.Int(nullable: false));
        }
    }
}
