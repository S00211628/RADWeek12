namespace Week12MVCHealthApp2223.S00211628.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingrolesandusers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "EntityID", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "EntityID");
        }
    }
}
