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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Behrens_System.View.Quotes.Quote_Items
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AddProduct : Page
    {
        public AddProduct()
        {
            this.InitializeComponent();
        }

        private void btnFabricCurtains_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(BHQCdetm));
        }

        private void btnDisposableCurtains_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnVerticalBlinds_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(BHQVBdetm));
        }

        private void btnRollerBlinds_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(BHQRBdetm));
        }

        private void btnTracking_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnBedding_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnFitting_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnMisc_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
