namespace BaseApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLengthLimiteClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LengthLimites",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MaxLength = c.Double(nullable: false),
                        MinLength = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.SportTypes", "LengthLimite_Id", c => c.Int());
            CreateIndex("dbo.SportTypes", "LengthLimite_Id");
            AddForeignKey("dbo.SportTypes", "LengthLimite_Id", "dbo.LengthLimites", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SportTypes", "LengthLimite_Id", "dbo.LengthLimites");
            DropIndex("dbo.SportTypes", new[] { "LengthLimite_Id" });
            DropColumn("dbo.SportTypes", "LengthLimite_Id");
            DropTable("dbo.LengthLimites");
        }
    }
}
