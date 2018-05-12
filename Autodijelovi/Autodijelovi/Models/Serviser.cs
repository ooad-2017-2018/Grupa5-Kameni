using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autodijelovi.Models
{
    class Serviser: Uposlenik
    {
        string radnaPozicija;
        List<string> najcesciPoslovi = new List<string>();
        List<string> dozvoljeneMasine = new List<string>();
        Servis mjestoZaposlenja = new Servis();


        public Serviser()
        {

        }

        public Serviser(string ime, string prezime, string telefon, string email, string cV, Poslovnica poslovnica, Uposlenik nadređeni, List<Uposlenik> podredjeni, string korisnickoIme, string sifra, float plata, DateTime datumZaposlenja,string radnaPozicija, List<string> najcesciPoslovi, List<string> dozvoljeneMasine, Servis servis): base( ime, prezime, telefon, email, cV,  poslovnica,  nadređeni, podredjeni, korisnickoIme, sifra, plata, datumZaposlenja)
        {
            this.radnaPozicija = radnaPozicija;
            this.najcesciPoslovi = najcesciPoslovi;
            this.dozvoljeneMasine = dozvoljeneMasine;
            this.mjestoZaposlenja = servis;
        }

        public string RadnaPozicija { get => radnaPozicija; set => radnaPozicija = value; }
        public List<string> NajcesciPoslovi { get => najcesciPoslovi; set => najcesciPoslovi = value; }
        public List<string> DozvoljeneMasine { get => dozvoljeneMasine; set => dozvoljeneMasine = value; }
        internal Servis MjestoZaposlenja { get => mjestoZaposlenja; set => mjestoZaposlenja = value; }
    }
}
