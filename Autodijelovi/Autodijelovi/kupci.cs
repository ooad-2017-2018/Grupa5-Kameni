using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autodijelovi
{
    public class kupci
    {
        public string id
        {
            get;
            set;
        }
        public string ime
        {
            get;
            set;
        }
        public string prezime
        {
            get;
            set;
        }
        public string korisnicko_ime
        {
            get;
            set;
        }
        public string sifra
        {
            get;
            set;
        }
        public DateTime datum_registrovanja
        {
            get;
            set;
        }
        public Decimal popust
        {
            get;
            set;
        }
        public Int32 broj_narudzbi
        {
            get;
            set;
        }
}
}
