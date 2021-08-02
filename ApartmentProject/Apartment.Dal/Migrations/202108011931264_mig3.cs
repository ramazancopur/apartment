namespace Apartment.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Receipts", "HirerID", "dbo.Hirers");
            DropForeignKey("dbo.Receipts", "HostID", "dbo.Hosts");
            DropIndex("dbo.Receipts", new[] { "HirerID" });
            DropIndex("dbo.Receipts", new[] { "HostID" });
            AlterColumn("dbo.Receipts", "HirerID", c => c.Int());
            AlterColumn("dbo.Receipts", "HostID", c => c.Int());
            CreateIndex("dbo.Receipts", "HirerID");
            CreateIndex("dbo.Receipts", "HostID");
            AddForeignKey("dbo.Receipts", "HirerID", "dbo.Hirers", "HirerID");
            AddForeignKey("dbo.Receipts", "HostID", "dbo.Hosts", "HostID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Receipts", "HostID", "dbo.Hosts");
            DropForeignKey("dbo.Receipts", "HirerID", "dbo.Hirers");
            DropIndex("dbo.Receipts", new[] { "HostID" });
            DropIndex("dbo.Receipts", new[] { "HirerID" });
            AlterColumn("dbo.Receipts", "HostID", c => c.Int(nullable: false));
            AlterColumn("dbo.Receipts", "HirerID", c => c.Int(nullable: false));
            CreateIndex("dbo.Receipts", "HostID");
            CreateIndex("dbo.Receipts", "HirerID");
            AddForeignKey("dbo.Receipts", "HostID", "dbo.Hosts", "HostID", cascadeDelete: true);
            AddForeignKey("dbo.Receipts", "HirerID", "dbo.Hirers", "HirerID", cascadeDelete: true);
        }
    }
}
