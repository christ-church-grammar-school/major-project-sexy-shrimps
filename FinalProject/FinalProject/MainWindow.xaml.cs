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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DispatcherTimer LiveTime = new DispatcherTimer();
            LiveTime.Interval = TimeSpan.FromSeconds(1);
            LiveTime.Tick += timer_Tick;
            LiveTime.Start();

            string path = "../../password.txt";
            string stu = File.ReadLines(path).First();
            string pass = File.ReadLines(path).ElementAt(1);
            student.Text = stu;
            password.Password = pass;
        }

        void timer_Tick(object sender, EventArgs e)
        {
            Date.Content = DateTime.Now.ToString("D");
            Time.Content = DateTime.Now.ToString("hh:mm:ss");
        }

        private void LogIn_Clicked(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Uri("Page1.xaml", UriKind.Relative));
        }

        private void MainFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
