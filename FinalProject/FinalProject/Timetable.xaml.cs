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

namespace FinalProject
{
    /// <summary>
    /// Interaction logic for Timetable.xaml
    /// </summary>
    public partial class Timetable : Page
    {
        public Timetable()
        {
            InitializeComponent();
        }
        private void Return_Clicked(object sender, RoutedEventArgs e)
        {
            TimetableFrame.Navigate(new Uri("Hub.xaml", UriKind.Relative));
        }
        private void TimetableFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
