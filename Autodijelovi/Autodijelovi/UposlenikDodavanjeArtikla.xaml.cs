using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Autodijelovi
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class UposlenikDodavanjeArtikla : Page
    {
        public UposlenikDodavanjeArtikla()
        {
            this.InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(UposlenikMainForma));
        }
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            ValidirajUnos();
        }

        private void ValidirajUnos()
        {
            if(this.textBoxNazivArt.Text.Length>0 && this.textBoxSifraArt.Text.Length >0 && this.textBoxKategorijaArt.Text.Length >0 && this.textBoxKolicinaArt.Text.Length>0 && this.textBoxArtMaloprodajna.Text.Length>0 && this.textBoxArtVeleprodajna.Text.Length > 0)
            {
                MessageDialog msdiag = new MessageDialog("Uspjesno ste dodali artikal!");
                msdiag.ShowAsync();
            }
            else
            {
                MessageDialog msdiag = new MessageDialog("Niste unijeli podatke, ili su pogresni podaci");
                msdiag.ShowAsync();
            }
        }
    }
}
