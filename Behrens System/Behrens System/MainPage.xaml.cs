using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
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
using Windows.UI.Popups;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Behrens_System
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        //string path;
        //SQLite.Net.SQLiteConnection conn;

        public MainPage()
        {
            this.InitializeComponent();
            //path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "BehrensHealthcare.sqlite");
            //conn = new SQLite.Net.SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), path);
            //conn.CreateTable<SystemUser>();
        }

        private async void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text;
            string password = pwdPassword.Password;
            Boolean found = false;
            //var query = conn.Table<SystemUser>();
            string result = string.Empty;
            string result2 = string.Empty;
            //foreach (var item in query)
            {
                result = "rcurran";
                result2 = "Pisswig1";
                if ((result == username) && (result2 == password))
                {
                    found = true;
                    Frame.Navigate(typeof(MainMenuSideBar));
                }
            }
            if (found == false)
            {
                MessageDialog msgbox = new MessageDialog("Sorry please check your username and password.");
                var res = await msgbox.ShowAsync();
            }

        }

        /*private async void GetButton_Click(object sender, RoutedEventArgs e)
        {
            //ToDoService.Service1Client service1Client = new ToDoService.Service1Client();
            //ToDoService.querySqlRequest request = new ToDoService.querySqlRequest();
            //ToDoService.querySqlResponse ds = await service1Client.querySqlAsync(request);

            if (ds.queryParam)
            {
                XDocument xdoc = XDocument.Parse(ds.querySqlRequest.Nodes[1].ToString(), LoadOptions.None);
                var data = from query in xdoc.Descendants("Table")
                           select new Users
                           {
                               Username = query.Element("username").Value,
                               Password = query.Element("password").Value
                           };
                //lvDataTemplates.ItemsSource = data;
            }
            else
            {

            }

        }
        */
    }
}
