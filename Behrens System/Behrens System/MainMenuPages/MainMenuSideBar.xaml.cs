using Behrens_System.View;
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

namespace Behrens_System
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainMenuSideBar : Page
    {
        public MainMenuSideBar()
        {
            this.InitializeComponent();
            MainMenuFrame.Navigate(typeof(MainMenuPages.MainMenuPage));
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            if (MainMenuFrame.CanGoBack)
            {
                MainMenuFrame.GoBack();
            }
        }

        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            splitMainMenu.IsPaneOpen = !splitMainMenu.IsPaneOpen;
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            MainMenuFrame.Navigate(typeof(MainMenuPages.MainMenuPage));
        }

        private void btnQuotes_Click(object sender, RoutedEventArgs e)
        {
            MainMenuFrame.Navigate(typeof(QuotesMenu));
        }

        private void btnSalesOrders_Click(object sender, RoutedEventArgs e)
        {
            MainMenuFrame.Navigate(typeof(View.SalesOrders.SalesOrderMenu));
        }

        private void btnProjects_Click(object sender, RoutedEventArgs e)
        {
            MainMenuFrame.Navigate(typeof(View.Projects.Projects));
        }

        private void btnPurchaseOrders_Click(object sender, RoutedEventArgs e)
        {
            MainMenuFrame.Navigate(typeof(View.PurchaseOrders.PurchaseOrderMenu));
        } 

        private void btnCustomers_Click(object sender, RoutedEventArgs e)
        {
            //MainMenuFrame.Navigate(typeof(Customers));
        }

        private void btnProducts_Click(object sender, RoutedEventArgs e)
        {
            //MainMenuFrame.Navigate(typeof(Products));
        }

        private void btnCompany_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSettings_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnUserProfile_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            //ViewModel.ExitSystem.exitSystem();
        }
    }
}
