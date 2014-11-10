namespace ChenMai.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Plant",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 100, unicode: false, storeType: "nvarchar"),
                        Name = c.String(nullable: false, maxLength: 300, unicode: false, storeType: "nvarchar"),
                        Remark = c.String(maxLength: 2000, unicode: false, storeType: "nvarchar"),
                        CreateDate = c.DateTime(nullable: false),
                        ModifyDate = c.DateTime(),
                        CreateUser_ID = c.String(maxLength: 128, unicode: false, storeType: "nvarchar"),
                        ModifyUser_ID = c.String(maxLength: 128, unicode: false, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.User", t => t.CreateUser_ID)
                .ForeignKey("dbo.User", t => t.ModifyUser_ID)
                .Index(t => t.CreateUser_ID)
                .Index(t => t.ModifyUser_ID);
            
            CreateTable(
                "dbo.OriginModel",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128, unicode: false, storeType: "nvarchar"),
                        Name = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128, unicode: false, storeType: "nvarchar"),
                        Password = c.String(unicode: false),
                        UserName = c.String(unicode: false),
                        RealName = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.PlantOriginRelations",
                c => new
                    {
                        PlantId = c.String(nullable: false, maxLength: 100, unicode: false, storeType: "nvarchar"),
                        OriginId = c.String(nullable: false, maxLength: 128, unicode: false, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => new { t.PlantId, t.OriginId })
                .ForeignKey("dbo.Plant", t => t.PlantId, cascadeDelete: true)
                .ForeignKey("dbo.OriginModel", t => t.OriginId, cascadeDelete: true)
                .Index(t => t.PlantId)
                .Index(t => t.OriginId);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.PlantOriginRelations", new[] { "OriginId" });
            DropIndex("dbo.PlantOriginRelations", new[] { "PlantId" });
            DropIndex("dbo.Plant", new[] { "ModifyUser_ID" });
            DropIndex("dbo.Plant", new[] { "CreateUser_ID" });
            DropForeignKey("dbo.PlantOriginRelations", "OriginId", "dbo.OriginModel");
            DropForeignKey("dbo.PlantOriginRelations", "PlantId", "dbo.Plant");
            DropForeignKey("dbo.Plant", "ModifyUser_ID", "dbo.User");
            DropForeignKey("dbo.Plant", "CreateUser_ID", "dbo.User");
            DropTable("dbo.PlantOriginRelations");
            DropTable("dbo.User");
            DropTable("dbo.OriginModel");
            DropTable("dbo.Plant");
        }
    }
}
