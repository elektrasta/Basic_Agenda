namespace Agenda.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDateFisier : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Fisiers", "data_si_ora", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Fisiers", "data_si_ora");
        }
    }
}
