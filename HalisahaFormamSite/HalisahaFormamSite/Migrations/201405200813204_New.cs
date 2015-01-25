namespace HalisahaFormamSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class New : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "User_Id", "dbo.RegisterModels");
            DropIndex("dbo.Orders", new[] { "User_Id" });
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Orders", "RegisterModel_Id", c => c.Int());
            AddColumn("dbo.RegisterModels", "City_Id", c => c.Int());
            CreateIndex("dbo.RegisterModels", "City_Id");
            CreateIndex("dbo.Orders", "RegisterModel_Id");
            AddForeignKey("dbo.RegisterModels", "City_Id", "dbo.Cities", "Id");
            AddForeignKey("dbo.Orders", "RegisterModel_Id", "dbo.RegisterModels", "Id");
            DropColumn("dbo.Orders", "User_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "User_Id", c => c.Int());
            DropForeignKey("dbo.Orders", "RegisterModel_Id", "dbo.RegisterModels");
            DropForeignKey("dbo.RegisterModels", "City_Id", "dbo.Cities");
            DropIndex("dbo.Orders", new[] { "RegisterModel_Id" });
            DropIndex("dbo.RegisterModels", new[] { "City_Id" });
            DropColumn("dbo.RegisterModels", "City_Id");
            DropColumn("dbo.Orders", "RegisterModel_Id");
            DropTable("dbo.Cities");
            CreateIndex("dbo.Orders", "User_Id");
            AddForeignKey("dbo.Orders", "User_Id", "dbo.RegisterModels", "Id");
        }
    }
}
