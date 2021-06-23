namespace CodeFirstEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Columnchanged : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Status", "Name", c => c.String());
            CreateIndex("dbo.Orders", "UserId");
            AddForeignKey("dbo.Orders", "UserId", "dbo.Users", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "UserId", "dbo.Users");
            DropIndex("dbo.Orders", new[] { "UserId" });
            AlterColumn("dbo.Status", "Name", c => c.Int(nullable: false));
        }
    }
}
