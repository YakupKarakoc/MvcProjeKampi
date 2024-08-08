namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contents", "ContentDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Contents", "ContentDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Contents", "ContentDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Contents", "ContentDate");
        }
    }
}
