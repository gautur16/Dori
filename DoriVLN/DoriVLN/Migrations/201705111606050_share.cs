namespace DoriVLN.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class share : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Files", "shareID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Files", "shareID");
        }
    }
}
