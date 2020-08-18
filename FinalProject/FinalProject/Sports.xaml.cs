using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.IO;
using System.Globalization;

namespace FinalProject
{
    /// <summary>
    /// Interaction logic for Sports.xaml
    /// </summary>
    public partial class Sports : Page
    {
        public Sports()
        {
            InitializeComponent();
        }

        private void Return_Clicked(object sender, RoutedEventArgs e)
        {
            SportsFrame.Navigate(new Uri("Hub.xaml", UriKind.Relative));
        }
        private void SportsFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
