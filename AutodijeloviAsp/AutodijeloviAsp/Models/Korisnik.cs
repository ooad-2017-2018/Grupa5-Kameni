using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutodijeloviAsp.Models
{
    public class Korisnik
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