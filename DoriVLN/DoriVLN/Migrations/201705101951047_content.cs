namespace DoriVLN.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class content : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Files", "content", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Files", "content");
        }
    }
}
