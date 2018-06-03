using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutodijeloviAsp.Models
{
    public class Korisnik
    {
        string ime, prezime;
        DateTime datumRegistrovanja = new DateTime();
        string korisnickoIme, sifra;
        float popust;
        int brojNarudzbi;

        public Korisnik()
        {

        }
        /* public Kupac(string ime, string prezime, DateTime datumRegistrovanja, string korisnickoIme, string sifra, float popust, int brojNarudzbi)
         {
             this.Ime = ime;
             this.Prezime = prezime;
             this.DatumRegistrovanja = datumRegistrovanja;
             this.KorisnickoIme = korisnickoIme;
             this.Sifra = sifra;
             this.Popust = popust;
             this.BrojNarudzbi = brojNarudzbi;
         }
         */
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public DateTime DatumRegistrovanja { get => datumRegistrovanja; set => datumRegistrovanja = value; }
        public string KorisnickoIme { get => korisnickoIme; set => korisnickoIme = value; }
        public string Sifra { get => sifra; set => sifra = value; }
        public float Popust { get => popust; set => popust = value; }
        public int BrojNarudzbi { get => brojNarudzbi; set => brojNarudzbi = value; }
    }
}