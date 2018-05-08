using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autodijelovi.Models
{
    class Uposlenik
    {
        string ime, prezime, telefon, email;
        string CV;
        Poslovnica poslovnica = new Poslovnica();
        Uposlenik nadređeni = new Uposlenik();
        List<Uposlenik> podredjeni = new List<Uposlenik>();
        string korisnickoIme, sifra;
        float plata;
        DateTime datumZaposlenja = new DateTime();

        public Uposlenik()
        {

        }

        public Uposlenik(string ime, string prezime, string telefon, string email, string cV, Poslovnica poslovnica, Uposlenik nadređeni, List<Uposlenik> podredjeni, string korisnickoIme, string sifra, float plata, DateTime datumZaposlenja)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.Telefon = telefon;
            this.Email = email;
            CV1 = cV;
            this.Poslovnica = poslovnica;
            this.Nadređeni = nadređeni;
            this.Podredjeni = podredjeni;
            this.KorisnickoIme = korisnickoIme;
            this.Sifra = sifra;
            this.Plata = plata;
            this.DatumZaposlenja = datumZaposlenja;
        }

        public string Ime { get => Ime1; set => Ime1 = value; }
        public string Prezime { get => Prezime1; set => Prezime1 = value; }
        public string Telefon { get => Telefon1; set => Telefon1 = value; }
        public string Email { get => Email1; set => Email1 = value; }
        public string CV1 { get => CV2; set => CV2 = value; }
        public string KorisnickoIme { get => KorisnickoIme1; set => KorisnickoIme1 = value; }
        public string Sifra { get => Sifra1; set => Sifra1 = value; }
        public float Plata { get => Plata1; set => Plata1 = value; }
        public DateTime DatumZaposlenja { get => DatumZaposlenja1; set => DatumZaposlenja1 = value; }
        public string Ime1 { get => ime; set => ime = value; }
        public string Prezime1 { get => prezime; set => prezime = value; }
        public string Telefon1 { get => telefon; set => telefon = value; }
        public string Email1 { get => email; set => email = value; }
        public string CV2 { get => CV; set => CV = value; }
        public string KorisnickoIme1 { get => korisnickoIme; set => korisnickoIme = value; }
        public string Sifra1 { get => sifra; set => sifra = value; }
        public float Plata1 { get => plata; set => plata = value; }
        public DateTime DatumZaposlenja1 { get => datumZaposlenja; set => datumZaposlenja = value; }
        internal Poslovnica Poslovnica { get => Poslovnica1; set => Poslovnica1 = value; }
        internal Uposlenik Nadređeni { get => Nadređeni1; set => Nadređeni1 = value; }
        internal List<Uposlenik> Podredjeni { get => Podredjeni1; set => Podredjeni1 = value; }
        internal Poslovnica Poslovnica1 { get => poslovnica; set => poslovnica = value; }
        internal Uposlenik Nadređeni1 { get => nadređeni; set => nadređeni = value; }
        internal List<Uposlenik> Podredjeni1 { get => podredjeni; set => podredjeni = value; }
    }
}
