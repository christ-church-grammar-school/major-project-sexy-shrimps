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
    /// Interaction logic for Subject.xaml
    /// </summary>
    public partial class Subject : Page
    {
        public Subject(string subject)
        {
            InitializeComponent();

            Subject9.Content = subject;
        }

        private void Return_Clicked(object sender, RoutedEventArgs e)
        {
            SubjectFrame.Navigate(new Uri("Diary.xaml", UriKind.Relative));
        }

        private void SubjectFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
