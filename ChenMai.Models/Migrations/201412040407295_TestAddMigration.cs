namespace ChenMai.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TestAddMigration : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Plant", "PlantFamilies");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Plant", "PlantFamilies", c => c.String(unicode: false));
        }
    }
}
