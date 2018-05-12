using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autodijelovi.Models
{
    public class Skladiste
    {
        string Lokacija;
        Uposlenik menadzer;
        List<Uposlenik> zaposleni = new List<Uposlenik>();
        List<Artikal> artili = new List<Artikal>();
        string teretorija;

        public Skladiste()
        {

        }

        public Skladiste(string lokacija, Uposlenik menadzer, List<Uposlenik> zaposleni, List<Artikal> artili, string teretorija)
        {
            Lokacija = lokacija;
            this.menadzer = menadzer;
            this.zaposleni = zaposleni;
            this.artili = artili;
            this.teretorija = teretorija;
        }

        public string Lokacija1 { get => Lokacija; set => Lokacija = value; }
        public string Teretorija { get => teretorija; set => teretorija = value; }
        internal Uposlenik Menadzer { get => menadzer; set => menadzer = value; }
        internal List<Uposlenik> Zaposleni { get => zaposleni; set => zaposleni = value; }
        internal List<Artikal> Artili { get => artili; set => artili = value; }
    }
}
