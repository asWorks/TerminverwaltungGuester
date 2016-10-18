namespace Termineverwaltung.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedTermine : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Patiententermin",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Termin = c.DateTime(nullable: false),
                        Dauer = c.Time(nullable: false, precision: 7),
                        MitarbeiterId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Mitarbeiter", t => t.MitarbeiterId, cascadeDelete: true)
                .Index(t => t.MitarbeiterId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Patiententermin", "MitarbeiterId", "dbo.Mitarbeiter");
            DropIndex("dbo.Patiententermin", new[] { "MitarbeiterId" });
            DropTable("dbo.Patiententermin");
        }
    }
}
