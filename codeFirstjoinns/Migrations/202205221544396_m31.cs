namespace codeFirstjoinns.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m31 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.products", "Decs", c => c.String());
            AddColumn("dbo.products", "Quntety", c => c.Int(nullable: false));
            DropColumn("dbo.products", "gander");
            DropColumn("dbo.products", "Age");
        }
        
        public override void Down()
        {
            AddColumn("dbo.products", "Age", c => c.Int(nullable: false));
            AddColumn("dbo.products", "gander", c => c.String());
            DropColumn("dbo.products", "Quntety");
            DropColumn("dbo.products", "Decs");
        }
    }
}
