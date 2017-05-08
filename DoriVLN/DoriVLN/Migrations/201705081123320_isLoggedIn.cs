namespace DoriVLN.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class isLoggedIn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "isLoggedIn", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "isLoggedIn");
        }
    }
}
