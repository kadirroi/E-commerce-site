namespace HalisahaFormamSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class New1 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Orders", name: "RegisterModel_Id", newName: "User_Id");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.Orders", name: "User_Id", newName: "RegisterModel_Id");
        }
    }
}
