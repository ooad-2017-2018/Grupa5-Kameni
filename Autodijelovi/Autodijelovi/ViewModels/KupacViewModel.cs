using Autodijelovi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autodijelovi.ViewModels
{
    public class KupacViewModel
    {
        string _korisnickoIme;
        string _sifra;

        public KupacViewModel()
        {

        }

        public string KorisnickoIme { get => _korisnickoIme; set => _korisnickoIme = value; }
        public string Sifra { get => _sifra; set => _sifra = value; }

        public static KupacViewModel kupac(Kupac k)
        {
            var viewModel = new KupacViewModel();
            viewModel._sifra = k.Sifra;
            viewModel.KorisnickoIme = k.KorisnickoIme;

            return viewModel;

        }
    }
}
