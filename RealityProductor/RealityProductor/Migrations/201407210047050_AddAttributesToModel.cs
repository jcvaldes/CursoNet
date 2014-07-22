namespace RealityProductor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAttributesToModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Competitors", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Competitors", "Lastname", c => c.String(nullable: false));
            AlterColumn("dbo.Competitors", "Address", c => c.String(nullable: false));
            AlterColumn("dbo.Competitors", "Phone", c => c.String(maxLength: 8));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Competitors", "Phone", c => c.String());
            AlterColumn("dbo.Competitors", "Address", c => c.String());
            AlterColumn("dbo.Competitors", "Lastname", c => c.String());
            AlterColumn("dbo.Competitors", "Name", c => c.String());
        }
    }
}
