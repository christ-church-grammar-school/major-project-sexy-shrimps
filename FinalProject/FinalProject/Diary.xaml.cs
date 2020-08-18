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

            string path = "../../Diary/17-8-2020.txt";
            string hs = File.ReadAllText(path);
            Diary.Text = hs;

            string path3 = "../../user.txt";
            string user = File.ReadLines(path3).First();
            string path2 = "../../Users/" + user + ".txt";

            sub1.Text = File.ReadLines(path2).ElementAt(5);
            sub2.Text = File.ReadLines(path2).ElementAt(6);
            sub3.Text = File.ReadLines(path2).ElementAt(7);
            sub4.Text = File.ReadLines(path2).ElementAt(8);
            sub5.Text = File.ReadLines(path2).ElementAt(9);
            sub6.Text = File.ReadLines(path2).ElementAt(10);
            sub7.Text = File.ReadLines(path2).ElementAt(11);

        }

        private void save(object sender, RoutedEventArgs e)
        {
            string path = "../../Diary/17-8-2020.txt";
            File.WriteAllText(path, String.Empty);
            TextWriter tw = new StreamWriter(path, true);
            tw.WriteLine(Diary.Text);
            tw.Close();
        }

        private void Return_Clicked(object sender, RoutedEventArgs e)
        {
            DiaryFrame.Navigate(new Uri("Hub.xaml", UriKind.Relative));
        }

        private void DiaryFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
