namespace KameniAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Korisnik")]
    public partial class Korisnik
    {
        public string KorisnikID { get; set; }

        public string userName { get; set; }

        public string password { get; set; }

        public string email { get; set; }

        public DateTime datumRegistrovanja { get; set; }

        public float popust { get; set; }

        public int brojNarudzbi { get; set; }
    }
}
