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

        public Dostava()
        {

        }

        public Dostava(Dostavljac dostavljac, DateTime vrijemePolaska, List<DostavnoVozilo> dostavnoVozila, List<Artikal> artikli)
        {
            this.Dostavljac = dostavljac;
            this.VrijemePolaska = vrijemePolaska;
            this.DostavnoVozila = dostavnoVozila;
            this.Artikli = artikli;
        }

        public DateTime VrijemePolaska { get => vrijemePolaska; set => vrijemePolaska = value; }
        internal Dostavljac Dostavljac { get => dostavljac; set => dostavljac = value; }
        internal List<DostavnoVozilo> DostavnoVozila { get => dostavnoVozila; set => dostavnoVozila = value; }
        internal List<Artikal> Artikli { get => artikli; set => artikli = value; }
    }
}
