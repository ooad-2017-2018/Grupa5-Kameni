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
    public sealed partial class UposlenikMedjuforma : Page
    {
        public UposlenikMedjuforma()
        {
            this.InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Pocetna));
        }
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(UposlenikRegistracija));
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            if(this.textBoxUsername.Text.Equals("radnik") && this.textBoxUserPass.Password.Equals("123"))
            {
                this.Frame.Navigate(typeof(UposlenikMainForma));
            }
            else if(this.textBoxUsername.Text.Length.Equals(0) && this.textBoxUserPass.Password.Length.Equals(0))
            {
                MessageDialog diag = new MessageDialog("Morate popuniti odgovarajuca polja!");
                diag.ShowAsync();
            }
            else
            {
                MessageDialog diag = new MessageDialog("Pogresni unosni podaci");
                diag.ShowAsync();
            }
        }
    }
}
