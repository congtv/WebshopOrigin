namespace Webshop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addErrorTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Feedbacks", "ProductID", c => c.Int(nullable: false));
            AddColumn("dbo.Feedbacks", "PostID", c => c.Int(nullable: false));
            AddColumn("dbo.Menus", "Target", c => c.String(maxLength: 10));
            DropColumn("dbo.Menus", "Targer");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Menus", "Targer", c => c.String(maxLength: 10));
            DropColumn("dbo.Menus", "Target");
            DropColumn("dbo.Feedbacks", "PostID");
            DropColumn("dbo.Feedbacks", "ProductID");
        }
    }
}
