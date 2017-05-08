namespace DoriVLN.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class relationmigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Files", "parentFolderID", c => c.Int(nullable: false));
            AddColumn("dbo.Folders", "parentFolderID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Folders", "parentFolderID");
            DropColumn("dbo.Files", "parentFolderID");
        }
    }
}
