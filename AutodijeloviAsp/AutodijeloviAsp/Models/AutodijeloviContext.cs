using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace AutodijeloviAsp.Models
{
    public class AutodijeloviContext : DbContext
    {
        public AutodijeloviContext() : base("AzureConnection") 
 {
        }
        //dodavanjem klasa iz modela kao DbSet iste će biti mapirane u bazu podataka
        public DbSet<Korisnik> Korisnik { get; set; }
        
        //Ova funkcija se koriste da bi se ukinulo automatsko dodavanje množine u nazive
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}