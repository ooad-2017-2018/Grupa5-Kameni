using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Microsoft.WindowsAzure.MobileServices;
using Windows.UI.Popups;
using Autodijelovi;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Autodijelovi
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class KupacRegistrovanje : Page
    {
        public KupacRegistrovanje()
        {
            this.InitializeComponent();
        }

        IMobileServiceTable<tabela> userTableObj = App.MobileService.GetTable<tabela>();

        private void SignUp_Click(object sender, RoutedEventArgs e)
        {
            if (ValidirajUnos())
            {
                try
                {
                    tabela obj = new tabela();
                    obj.ime = imetekst.Text;
                    obj.prezime = prezimetekst.Text;
                    obj.korisnickoIme = kimetekst.Text;
                    obj.sifra = sifra.Text;

                    userTableObj.InsertAsync(obj);
                    MessageDialog msgDialog = new MessageDialog("Uspješno ste registrovani u sistem. Želimo van ugodno korištenje aplikacije Autodijelovi Kameni :) ");

                    msgDialog.ShowAsync();

                    this.Frame.Navigate(typeof(MainPage));
                }
                catch (Exception ex)
                {
                    MessageDialog msgDialogError = new MessageDialog("Error : " + ex.ToString());
                    msgDialogError.ShowAsync();
                }
            }
            else
            {
                MessageDialog msdiag = new MessageDialog("Niste unijeli podatke ispravno!");
                msdiag.ShowAsync();
            }
        }
        private bool ValidirajUnos()
        {
            if (this.imetekst.Text.Length > 0 && this.prezimetekst.Text.Length > 0 && this.kimetekst.Text.Length > 0 && this.sifra.Text.Length > 0 && this.datePickerDatum.Date != DateTime.Now)
            {
                return true;
            }
            return false;
        }
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(KupacIzbor));
        }
    }
}
