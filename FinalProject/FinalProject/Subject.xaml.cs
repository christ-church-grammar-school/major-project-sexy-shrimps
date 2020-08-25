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
    /// Interaction logic for Subject.xaml
    /// </summary>
    public partial class Subject : Page
    {
        public Subject(string subject)
        {
            InitializeComponent();

            Subject9.Content = subject;

            try
            {
                string path = $"../../Diary/{Subject9.Content}.txt";
                string hs = File.ReadAllText(path);
                Diary.Text = hs.Remove(hs.LastIndexOf(Environment.NewLine));
            }
            catch (FileNotFoundException)
            {
                string path = $"../../Diary/{Subject9.Content}.txt";
                File.WriteAllLines(path, new string[0]);
                string hs = File.ReadAllText(path);
                Diary.Text = hs;
            }
            catch (ArgumentOutOfRangeException)
            {
                string path = $"../../Diary/{Subject9.Content}.txt";
                File.WriteAllLines(path, new string[0]);
                string hs = File.ReadAllText(path);
                Diary.Text = hs;
            }
        }

        private void Return_Clicked(object sender, RoutedEventArgs e)
        {
            string path = $"../../Diary/{Subject9.Content}.txt";


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
            SubjectFrame.Navigate(new Uri("Diary.xaml", UriKind.Relative));
        }

        private void SubjectFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void save(object sender, RoutedEventArgs e)
        {
            string path = $"../../Diary/{Subject9.Content}.txt";


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
    }
}
