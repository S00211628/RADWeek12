namespace Week12HealthDomain2223.S00211628.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingfirstnameandsecondnametopatientsdatabase : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Patients", "FirstName", c => c.String());
            AddColumn("dbo.Patients", "SecondName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Patients", "SecondName");
            DropColumn("dbo.Patients", "FirstName");
        }
    }
}
