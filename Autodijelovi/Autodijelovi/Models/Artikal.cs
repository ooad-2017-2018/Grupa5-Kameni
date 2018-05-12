using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autodijelovi.Models
{
    public class Artikal
    {
        string naziv;
        Int32 kolicina;
        enum tipArtikla { };
        Skladiste skladiste = new Skladiste();
        float cijenMaloprodajna;
        float cijenVeleprodajna;
        Int32 minDozvoljenaKolicina;
        List<string> automobili=new List<string>();

        
public Artikal(string naziv, int kolicina, Skladiste skladiste, float cijenMaloprodajna, float cijenVeleprodajna, int minDozvoljenaKolicina, List<string> automobili)
        {
            this.naziv = naziv;
            this.kolicina = kolicina;
            this.skladiste = skladiste;
            this.cijenMaloprodajna = cijenMaloprodajna;
            this.cijenVeleprodajna = cijenVeleprodajna;
            this.minDozvoljenaKolicina = minDozvoljenaKolicina;
            this.automobili = automobili;
        }

        public float CijenMaloprodajna { get => cijenMaloprodajna; set => cijenMaloprodajna = value; }
        public float CijenVeleprodajna { get => cijenVeleprodajna; set => cijenVeleprodajna = value; }
        public int MinDozvoljenaKolicina { get => minDozvoljenaKolicina; set => minDozvoljenaKolicina = value; }
        public List<string> Automobili { get => automobili; set => automobili = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public int Kolicina { get => kolicina; set => kolicina = value; }
        internal Skladiste Skladiste { get => skladiste; set => skladiste = value; }

        

    }
}
