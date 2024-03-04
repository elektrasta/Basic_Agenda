namespace Agenda.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFisierClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Fisiers",
                c => new
                    {
                        FisierId = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        NumeReal = c.String(nullable: false),
                        NumeCriptat = c.String(),
                        Open = c.Boolean(nullable: false),
                        ShareList = c.String(),
                    })
                .PrimaryKey(t => t.FisierId)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Fisiers", "UserId", "dbo.Users");
            DropIndex("dbo.Fisiers", new[] { "UserId" });
            DropTable("dbo.Fisiers");
        }
    }
}
