namespace Termineverwaltung.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MitarbeiterGeburtstag : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Mitarbeiter",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nachname = c.String(unicode: false),
                        Vorname = c.String(unicode: false),
                        Geburtsdatum = c.DateTime(nullable: false),
                        IstBehandler = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Mitarbeiter");
        }
    }
}
