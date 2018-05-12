using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autodijelovi.Models
{
    public class Kameni
    {
        List<Poslovnica> poslovnice = new List<Poslovnica>();
        List<Skladiste> skladista = new List<Skladiste>();
        List<Servis> serviis = new List<Servis>();
        DateTime datumOsnivanja = new DateTime();
        Uposlenik vlasnik;
        string teretorijaPoslovanja;
        Poslovnica sjedista = new Poslovnica();

        public Kameni()
        {

        }

        public Kameni(List<Poslovnica> poslovnice, List<Skladiste> skladista, List<Servis> serviis, DateTime datumOsnivanja, Uposlenik vlasnik, string teretorijaPoslovanja, Poslovnica sjedista)
        {
            this.Poslovnice = poslovnice;
            this.Skladista = skladista;
            this.Serviis = serviis;
            this.DatumOsnivanja = datumOsnivanja;
            this.Vlasnik = vlasnik;
            this.TeretorijaPoslovanja = teretorijaPoslovanja;
            this.Sjedista = sjedista;
        }

        public DateTime DatumOsnivanja { get => datumOsnivanja; set => datumOsnivanja = value; }
        public string TeretorijaPoslovanja { get => teretorijaPoslovanja; set => teretorijaPoslovanja = value; }
        internal List<Poslovnica> Poslovnice { get => poslovnice; set => poslovnice = value; }
        internal List<Skladiste> Skladista { get => skladista; set => skladista = value; }
        internal List<Servis> Serviis { get => serviis; set => serviis = value; }
        internal Uposlenik Vlasnik { get => vlasnik; set => vlasnik = value; }
        internal Poslovnica Sjedista { get => sjedista; set => sjedista = value; }
    }
}
