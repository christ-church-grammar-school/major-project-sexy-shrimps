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
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;




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
            if (File.ReadLines(path).First() != "..")
            {
                string stu = File.ReadLines(path).First();
                string pass = File.ReadLines(path).ElementAt(1);
                student.Text = stu;
                password.Password = pass;
                remember.IsChecked = true;
            }
        }

        void timer_Tick(object sender, EventArgs e)
        {
            Date.Content = DateTime.Now.ToString("D");
            Time.Content = DateTime.Now.ToString("hh:mm:ss");
        }
        private void ErrorClosed(object sender, RoutedEventArgs e)
        {
            close.Opacity = 0;
            close.IsEnabled = false;
            message.Opacity = 0;
            warning.Opacity = 0;
            password.IsEnabled = true;
            student.IsEnabled = true;
            remember.IsEnabled = true;
            log.IsEnabled = true;
        }

        private void ShowError()
        {
            close.Opacity = 100;
            close.IsEnabled = true;
            message.Opacity = 100;
            warning.Opacity = 100;
            password.IsEnabled = false;
            student.IsEnabled = false;
            remember.IsEnabled = false;
            log.IsEnabled = false;
        }

        private void LogIn_Clicked(object sender, RoutedEventArgs e)
        {
            string path = "../../password.txt";
            File.WriteAllText(path, String.Empty);
            TextWriter tw = new StreamWriter(path, true);
            if (remember.IsChecked == true)
            {
                tw.WriteLine(student.Text);
                tw.WriteLine(password.Password);
                tw.Close();
            }
            else
            {
                tw.WriteLine("..");
                tw.Close();
            }
           

           

            string login = "../../Users/" + student.Text + "/student.txt";
            if (File.Exists(login))
            {
                if (File.ReadLines(login).ElementAt(1) == password.Password)
                {
                    MainFrame.Navigate(new Uri("Hub.xaml", UriKind.Relative));
                    string userpath = "../../user.txt";
                    File.WriteAllText(userpath, String.Empty);
                    TextWriter ww = new StreamWriter(userpath, true);
                    ww.WriteLine(student.Text);
                    ww.Close();
                }
                else
                {
                    ShowError();
                }
            }
            else
            {
                ShowError();
            }
               
        }

        private void MainFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }

      

        private void User_win(object sender, RoutedEventArgs e)
        {
            
            UsInfo win2 = new UsInfo();
            win2.Show();
        }
    }
}
