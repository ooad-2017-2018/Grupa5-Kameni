using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autodijelovi.Models
{
   public class DostavnoVozilo
    {
        string tip;
        float kapacitet;
        Dostavljac dostavljac = new Dostavljac();
        string registarskeOznake;

        public DostavnoVozilo()
        {

        }

        public DostavnoVozilo(string tip, float kapacitet, Dostavljac dostavljac, string registarskeOznake)
        {
            this.tip = tip;
            this.kapacitet = kapacitet;
            this.dostavljac = dostavljac;
            this.registarskeOznake = registarskeOznake;
        }

        public string Tip { get => tip; set => tip = value; }
        public float Kapacitet { get => kapacitet; set => kapacitet = value; }
        public string RegistarskeOznake { get => registarskeOznake; set => registarskeOznake = value; }
        internal Dostavljac Dostavljac { get => dostavljac; set => dostavljac = value; }
    }
}
