namespace Agenda.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class data_si_ora : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Agenda", "data_si_ora", c => c.DateTime(nullable: false));
            DropColumn("dbo.Agenda", "data");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Agenda", "data", c => c.DateTime(nullable: false));
            DropColumn("dbo.Agenda", "data_si_ora");
        }
    }
}
