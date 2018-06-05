using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public sealed partial class UposlenikRegistracija : Page
    {
        ObservableCollection<String> radnaMjesta = new ObservableCollection<String>();

        public UposlenikRegistracija()
        {
            this.InitializeComponent();

            radnaMjesta.Add("Skladiste 1");
            radnaMjesta.Add("Maloprodajna radnja");
            radnaMjesta.Add("Servis 1");

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(UposlenikMedjuforma));
        }
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            if(this.textBoxIme.Text.Length>0 && this.textBoxPrezime.Text.Length >0 && this.textBoxTelefon.Text.Length >0 && this.textBoxEmail.Text.Length >0 && this.textBoxKorisnickoIme.Text.Length > 0 && this.textBoxKorisnickaSifra.Text.Length > 0)
            {
                MessageDialog msgDialog = new MessageDialog("Uspjesno ste registrovali uposlenika!");
                msgDialog.ShowAsync();
            }
            else
            {
                MessageDialog msgDialog = new MessageDialog("Progresni unosni podaci ili ne popunjena polja. Molimo ispravno popunite informacije!");
                msgDialog.ShowAsync();
            }
            
        }
    }
}
