namespace BaseApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class something1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Medals", "Athlet_Id", "dbo.Athlets");
            DropIndex("dbo.Medals", new[] { "Athlet_Id" });
            CreateTable(
                "dbo.MedalAthlets",
                c => new
                    {
                        Medal_Id = c.Int(nullable: false),
                        Athlet_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Medal_Id, t.Athlet_Id })
                .ForeignKey("dbo.Medals", t => t.Medal_Id, cascadeDelete: true)
                .ForeignKey("dbo.Athlets", t => t.Athlet_Id, cascadeDelete: true)
                .Index(t => t.Medal_Id)
                .Index(t => t.Athlet_Id);
            
            DropColumn("dbo.Medals", "Athlet_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Medals", "Athlet_Id", c => c.Int());
            DropForeignKey("dbo.MedalAthlets", "Athlet_Id", "dbo.Athlets");
            DropForeignKey("dbo.MedalAthlets", "Medal_Id", "dbo.Medals");
            DropIndex("dbo.MedalAthlets", new[] { "Athlet_Id" });
            DropIndex("dbo.MedalAthlets", new[] { "Medal_Id" });
            DropTable("dbo.MedalAthlets");
            CreateIndex("dbo.Medals", "Athlet_Id");
            AddForeignKey("dbo.Medals", "Athlet_Id", "dbo.Athlets", "Id");
        }
    }
}
