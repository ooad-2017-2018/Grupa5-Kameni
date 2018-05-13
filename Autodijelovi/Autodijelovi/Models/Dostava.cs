using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autodijelovi.Models
{
    public class Dostava
    {
        Dostavljac dostavljac = new Dostavljac();
        DateTime vrijemePolaska = new DateTime();
        List<DostavnoVozilo> dostavnoVozila = new List<DostavnoVozilo>();
        List<Artikal> artikli = new List<Artikal>();
        string adresa;
        Kupac kupac = new Kupac();

        public Dostava()
        {

        }

        public Dostava(Kupac kupac, Dostavljac dostavljac, DateTime vrijemePolaska, List<DostavnoVozilo> dostavnoVozila, List<Artikal> artikli, string adresa)
        {
            this.Kupac = kupac;
            this.Dostavljac = dostavljac;
            this.VrijemePolaska = vrijemePolaska;
            this.DostavnoVozila = dostavnoVozila;
            this.Artikli = artikli;
            this.Adresa = adresa;
        }

        public Kupac Kupac { get => kupac; set => kupac = value; }
        public string Adresa { get => adresa; set => adresa = value; }
        public DateTime VrijemePolaska { get => vrijemePolaska; set => vrijemePolaska = value; }
        internal Dostavljac Dostavljac { get => dostavljac; set => dostavljac = value; }
        internal List<DostavnoVozilo> DostavnoVozila { get => dostavnoVozila; set => dostavnoVozila = value; }
        internal List<Artikal> Artikli { get => artikli; set => artikli = value; }
    }
}
