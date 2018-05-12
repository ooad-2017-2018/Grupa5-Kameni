using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autodijelovi.Models
{
   public  class DataSource
    {
        #region Kupac - kreiranje testnih kupaca
        private static List<Kupac> _kupci = new List<Kupac>()
        {
            new Kupac()
            {
                Ime="Esma",
                Prezime="Herenda",
                KorisnickoIme="sefica",
                Sifra="123"

            },
            new Kupac()
            {
                Ime="Sedad",
                Prezime="Kamencic",
                KorisnickoIme="malikamen",
                Sifra="456"
            },
            new Kupac()
            {
                Ime="Adis",
                Prezime="Hodzic",
                KorisnickoIme="zabušant",
                Sifra="789"
            }

        };
        public static IList<Kupac> DajSveKupce()
        {
            return _kupci;
        }
        public static Kupac DajKupcaPoSifri(int sifra)
        {
            return _kupci.Where(k => k.Sifra.Equals(sifra)).FirstOrDefault();
        }        public static Kupac ProvjeraKupca(string korisnickoIme, string sifra)
        {
            //Kupac rezultat = new Kupac();
            foreach (var k in DajSveKupce())
            {
                if (k.KorisnickoIme == korisnickoIme && k.Sifra == sifra)
                {
                    Kupac rezultat = new Kupac();
                    return rezultat;
                }
            }
            return null;
        }


        #endregion
    }
}
