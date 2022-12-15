namespace Week12HealthDomain2223.S00211628.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingtitleproptodoctors : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Doctors",
                c => new
                    {
                        DSS = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        FirstName = c.String(),
                        SecondName = c.String(),
                        Specilization = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.DSS);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Insurance = c.String(),
                        DSS = c.Int(nullable: false),
                        DateAdmitted = c.DateTime(nullable: false, storeType: "date"),
                        DateCheckedOut = c.DateTime(nullable: false, storeType: "date"),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Doctors", t => t.DSS)
                .Index(t => t.DSS);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Patients", "DSS", "dbo.Doctors");
            DropIndex("dbo.Patients", new[] { "DSS" });
            DropTable("dbo.Patients");
            DropTable("dbo.Doctors");
        }
    }
}
