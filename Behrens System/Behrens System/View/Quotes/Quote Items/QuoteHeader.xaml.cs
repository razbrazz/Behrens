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
    public sealed partial class QuoteHeader : Page
    {
        public QuoteHeader()
        {
            this.InitializeComponent();
        }

        private void btnQuoteDocs_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnQuoteStatus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAmendments_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnTracking_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAddItem_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AddProduct));
        }

        private void btnCustomerInformation_Click(object sender, RoutedEventArgs e)
        {
            btnCustomerInformation.Background = (SolidColorBrush)Resources["LightGreenColour"];
            btnQuoteInformation.Background = (SolidColorBrush)Resources["WhiteColour"];
            QuoteHeaderBox1.Navigate(typeof(CustomerInformation));
        }

        private void btnQuoteInformation_Click(object sender, RoutedEventArgs e)
        {
            btnCustomerInformation.Background = (SolidColorBrush)Resources["WhiteColour"];
            btnQuoteInformation.Background = (SolidColorBrush)Resources["LightGreenColour"];
            QuoteHeaderBox1.Navigate(typeof(QuoteInformation));
        }
    }
}
