namespace DoriVLN.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ffodlers : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Files", "dateTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Files", "dateTime", c => c.String());
        }
    }
}
