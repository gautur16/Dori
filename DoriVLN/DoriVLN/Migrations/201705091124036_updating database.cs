namespace DoriVLN.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatingdatabase : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Users", "name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "name", c => c.String());
        }
    }
}
