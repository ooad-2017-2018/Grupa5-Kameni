using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autodijelovi
{
    public class artikli
    {
        public string id
        {
            get;
            set;
        }
        public string naziv
        {
            get;
            set;
        }
        public int kolicina
        {
            get;
            set;
        }
        public string id_skladista
        {
            get;
            set;
        }
        public int cijena_maloprodajna
        {
            get;
            set;
        }
        public int cijena_veleprodajna
        {
            get;
            set;
        }
        public int min_dozvoljena_kolicina
        {
            get;
            set;
        }
    }
}
