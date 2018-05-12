using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autodijelovi.Models
{
    public class Poslovnica
    {
        string lokacija, kontakTelefon, email, naziv;
        List<Uposlenik> zaposleni = new List<Uposlenik>();
        Uposlenik menadzer;
        Poslovnica nadredjena = new Poslovnica();
        List<Poslovnica> podredjene = new List<Poslovnica>();
        
        


        public Poslovnica()
        {

        }

        public Poslovnica(string lokacija, string kontakTelefon, string email, string naziv, List<Uposlenik> zaposleni, Uposlenik menadzer, Poslovnica nadredjena, List<Poslovnica> podredjene)
        {
            this.lokacija = lokacija;
            this.kontakTelefon = kontakTelefon;
            this.email = email;
            this.naziv = naziv;
            this.zaposleni = zaposleni;
            this.menadzer = menadzer;
            this.nadredjena = nadredjena;
            this.podredjene = podredjene;
        }

        public string Lokacija { get => lokacija; set => lokacija = value; }
        public string KontakTelefon { get => kontakTelefon; set => kontakTelefon = value; }
        public string Email { get => email; set => email = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        internal List<Uposlenik> Zaposleni { get => zaposleni; set => zaposleni = value; }
        internal Uposlenik Menadzer { get => menadzer; set => menadzer = value; }
        internal Poslovnica Nadredjena { get => nadredjena; set => nadredjena = value; }
        internal List<Poslovnica> Podredjene { get => podredjene; set => podredjene = value; }
    }
}
