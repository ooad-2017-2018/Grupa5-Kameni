using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autodijelovi.Models
{
    public class Servis
    {
        Poslovnica poslovica = new Poslovnica();
        List<Uposlenik> zaposleni = new List<Uposlenik>();
        List<string> tipoviServisa = new List<string>();
        string lokacija;
        Int32 maxBrojvozila;
        List<string> masine = new List<string>();
        Uposlenik menadzer;

        public Servis()
        {

        }

        public Servis(Poslovnica poslovica, List<Uposlenik> zaposleni, List<string> tipoviServisa, string lokacija, int maxBrojvozila, List<string> masine, Uposlenik menadzer)
        {
            this.Poslovica = poslovica;
            this.Zaposleni = zaposleni;
            this.TipoviServisa = tipoviServisa;
            this.Lokacija = lokacija;
            this.MaxBrojvozila = maxBrojvozila;
            this.Masine = masine;
            this.Menadzer = menadzer;
        }

        public List<string> TipoviServisa { get => tipoviServisa; set => tipoviServisa = value; }
        public string Lokacija { get => lokacija; set => lokacija = value; }
        public int MaxBrojvozila { get => maxBrojvozila; set => maxBrojvozila = value; }
        public List<string> Masine { get => masine; set => masine = value; }
        internal Poslovnica Poslovica { get => poslovica; set => poslovica = value; }
        internal List<Uposlenik> Zaposleni { get => zaposleni; set => zaposleni = value; }
        internal Uposlenik Menadzer { get => menadzer; set => menadzer = value; }
    }
}
