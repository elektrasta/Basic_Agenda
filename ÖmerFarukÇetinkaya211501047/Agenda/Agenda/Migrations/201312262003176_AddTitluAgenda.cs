namespace Agenda.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTitluAgenda : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Agenda", "titlu", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Agenda", "titlu");
        }
    }
}
