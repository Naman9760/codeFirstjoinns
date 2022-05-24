namespace codeFirstjoinns.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.categaris",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        gander = c.String(),
                        Age = c.Int(nullable: false),
                        categari_id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.categaris", t => t.categari_id)
                .Index(t => t.categari_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.products", "categari_id", "dbo.categaris");
            DropIndex("dbo.products", new[] { "categari_id" });
            DropTable("dbo.products");
            DropTable("dbo.categaris");
        }
    }
}
