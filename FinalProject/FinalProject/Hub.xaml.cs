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

namespace FinalProject
{
    /// <summary>
    /// Interaction logic for Hub.xaml
    /// </summary>
    public partial class Hub : Page
    {
        public Hub()
        {
            InitializeComponent();
        }
        private void Diary_Clicked(object sender, RoutedEventArgs e)
        {
            HubFrame.Navigate(new Uri("Diary.xaml", UriKind.Relative));
        }
        private void HubFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
