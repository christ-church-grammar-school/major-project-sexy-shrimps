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

            string date = DateTime.Now.ToString("dd-MM-yyyy");
            date_top.Text = DateTime.Now.ToString("D");

            try
            {
                string path = $"../../Diary/{date}.txt";
                string hs = File.ReadAllText(path);
                Diary.Text = hs.Remove(hs.LastIndexOf(Environment.NewLine));
            }
            catch (FileNotFoundException)
            {
                string path = $"../../Diary/{date}.txt";
                File.WriteAllLines(path, new string[0]);
                string hs = File.ReadAllText(path);
                Diary.Text = hs;
            }
            catch (ArgumentOutOfRangeException)
            {
                string path = $"../../Diary/{date}.txt";
                File.WriteAllLines(path, new string[0]);
                string hs = File.ReadAllText(path);
                Diary.Text = hs;
            }
            



            string path3 = "../../user.txt";
            string user = File.ReadLines(path3).First();
            string path2 = "../../Users/" + user + ".txt";

            sub1.Text = File.ReadLines(path2).ElementAt(6);
            sub2.Text = File.ReadLines(path2).ElementAt(7);
            sub3.Text = File.ReadLines(path2).ElementAt(8);
            sub4.Text = File.ReadLines(path2).ElementAt(9);
            sub5.Text = File.ReadLines(path2).ElementAt(10);
            sub6.Text = File.ReadLines(path2).ElementAt(11);
            sub7.Text = File.ReadLines(path2).ElementAt(12);

            


        }

        private void save(object sender, RoutedEventArgs e)
        {
            string date = DateTime.Now.ToString("dd-MM-yyyy");
            string path = $"../../Diary/{date}.txt";


            if (Diary.Text == "")
            {
                File.Delete(path);
            }
            else
            {
                File.WriteAllText(path, String.Empty);
                TextWriter tw = new StreamWriter(path, true);
                tw.WriteLine(Diary.Text);
                tw.Close();
            }
            
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
