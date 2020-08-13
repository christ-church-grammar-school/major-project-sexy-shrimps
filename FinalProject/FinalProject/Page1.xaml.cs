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
using System.IO;

namespace FinalProject
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();


            string path = "../../Diary.txt";
            string hs = File.ReadAllText(path);
            Diary.Text = hs;
            
        }

        private void Save(object sender, RoutedEventArgs e)
        {
            string path = "../../Diary.txt";
            File.WriteAllText(path, String.Empty);
            TextWriter tw = new StreamWriter(path, true);
            tw.WriteLine(Diary.Text);
            tw.Close();
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("Page2.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
