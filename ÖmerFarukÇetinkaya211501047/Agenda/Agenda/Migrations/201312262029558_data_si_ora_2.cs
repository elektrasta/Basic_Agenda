namespace Agenda.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class data_si_ora_2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Agenda", "ora");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Agenda", "ora", c => c.DateTime(nullable: false));
        }
    }
}
