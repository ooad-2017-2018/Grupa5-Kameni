namespace AutodijeloviAsp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Korisnik",
                c => new
                    {
                        KorisnikID = c.String(nullable: false, maxLength: 128),
                        userName = c.String(),
                        password = c.String(),
                        email = c.String(),
                        datumRegistrovanja = c.DateTime(nullable: false),
                        popust = c.Single(nullable: false),
                        brojNarudzbi = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.KorisnikID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Korisnik");
        }
    }
}
