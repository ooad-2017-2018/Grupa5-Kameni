using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autodijelovi.Models
{
   public  class Dostavljac: Uposlenik
    {
        List<string> polozenekategorije = new List<string>();
        List<string> rute = new List<string>();
        string vozilo;

        public Dostavljac()
        {

        }

        public Dostavljac(string ime, string prezime, string telefon, string email, string cV, Poslovnica poslovnica, Uposlenik nadređeni, List<Uposlenik> podredjeni, string korisnickoIme, string sifra, float plata, DateTime datumZaposlenja,List<string> polozenekategorije, List<string> rute, string vozilo): base(ime, prezime, telefon, email, cV, poslovnica, nadređeni, podredjeni, korisnickoIme, sifra, plata, datumZaposlenja)
        {
            this.polozenekategorije = polozenekategorije;
            this.rute = rute;
            this.vozilo = vozilo;
        }

        public List<string> Polozenekategorije { get => polozenekategorije; set => polozenekategorije = value; }
        public List<string> Rute { get => rute; set => rute = value; }
        public string Vozilo { get => vozilo; set => vozilo = value; }
    }
}
