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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Behrens_System
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void GetButton_Click(object sender, RoutedEventArgs e)
        {
            ToDoService.Service1Client service1Client = new ToDoService.Service1Client();
            ToDoService.querySqlRequest request = new ToDoService.querySqlRequest();
            ToDoService.querySqlResponse ds = await service1Client.querySqlAsync(request);

            if (ds.queryParam)
            {
                XDocument xdoc = XDocument.Parse(ds.querySqlRequest.Nodes[1].ToString(), LoadOptions.None);
                var data = from query in xdoc.Descendants("Table")
                           select new Users
                           {
                               Username = query.Element("username").Value,
                               Password = query.Element("password").Value
                           };
                lvDataTemplates.ItemsSource = data;
            }
            else
            {

            }

        }
    }
}
