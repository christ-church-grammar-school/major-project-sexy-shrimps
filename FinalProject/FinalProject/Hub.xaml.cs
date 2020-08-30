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
    /// Interaction logic for Hub.xaml
    /// </summary>
    public partial class Hub : Page
    {
        public Hub()
        {
            InitializeComponent();

            DispatcherTimer LiveTime = new DispatcherTimer();
            LiveTime.Interval = TimeSpan.FromSeconds(1);
            LiveTime.Tick += timer_Tick;
            LiveTime.Start();

            WelcomeUser();
            GetDayOfFortnight();
            LoadTimetable();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            Time.Content = DateTime.Now.ToString("hh:mm:ss");
        }
        private void WelcomeUser()
        {
            string path = "../../user.txt";
            string user = File.ReadLines(path).First();

            string path2 = "../../Users/" + user + "/student.txt";
            string name = File.ReadLines(path2).ElementAt(3);
            welcome.Text = welcome.Text + name;
        }
        private void LoadTimetable()
        {
            int day = GetDayOfFortnight();
            TimetableDay.Text = "Timetable - Day " + day.ToString();

            string path = "../../user.txt";
            string user = File.ReadLines(path).First();
            string path2 = "../../Users/" + user + "/student.txt";
            string path3 = "../../Users/" + user + "/color.txt";

            int i = 5;
            while (File.ReadLines(path2).ElementAt(i) != day.ToString())
            {
                i += 8;
            }

            sub1.Text = File.ReadLines(path2).ElementAt(i+1);
            sub2.Text = File.ReadLines(path2).ElementAt(i+2);
            sub3.Text = File.ReadLines(path2).ElementAt(i+3);
            sub4.Text = File.ReadLines(path2).ElementAt(i+4);
            sub5.Text = File.ReadLines(path2).ElementAt(i+5);
            sub6.Text = File.ReadLines(path2).ElementAt(i+6);
            sub7.Text = File.ReadLines(path2).ElementAt(i+7);

            int dex = (day - 1) * 7;
            Sub0.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path3).ElementAt(dex));
            Sub1.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path3).ElementAt(dex+1));
            Sub2.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path3).ElementAt(dex+2));
            Sub3.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path3).ElementAt(dex+3));
            Sub4.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path3).ElementAt(dex+4));
            Sub5.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path3).ElementAt(dex+5));
            Sub6.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path3).ElementAt(dex+6));

            DateTime dateValue = DateTime.Now;
            int dayOfWeek = (int)dateValue.DayOfWeek;

            if (dayOfWeek != 0 && dayOfWeek != 6)
            {
                current.Opacity = 100;
                getCurrentPeriod();
            }
            else
            {
                current.Opacity = 0;
            }
        }

        public static int GetWeekOfYear(DateTime time)
        {
            DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(time);
            if (day >= DayOfWeek.Saturday && day <= DayOfWeek.Monday)
            {
                time = time.AddDays(3);
            }

            return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(time, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Saturday);
        }

        public static int GetDayOfFortnight()
        {
            int weekOfYear = GetWeekOfYear(DateTime.Now) - 1;
            DateTime now = DateTime.Now;
            int day = 0;

            if (weekOfYear % 2 == 0)
            {
                day = (int)now.DayOfWeek;
                if (day == 6 || day == 0)
                {
                    day = 1;
                }
            }
            else
            {
                day = (int)now.DayOfWeek + 5;
                if (day == 11 || day == 5)
                {
                    day = 6;
                }
            }
            return day;
        }
        public void getCurrentPeriod()
        {
            TimeSpan TutorialStart = new TimeSpan(8, 30, 0); 
            TimeSpan TutorialEnd = new TimeSpan(8, 50, 0);
            TimeSpan Period1Start = new TimeSpan(8, 55, 0);
            TimeSpan Period1End = new TimeSpan(9, 45, 0);
            TimeSpan Period2Start = new TimeSpan(9, 50, 0);
            TimeSpan Period2End = new TimeSpan(10, 40, 0);
            TimeSpan Period3Start = new TimeSpan(11, 00, 0);
            TimeSpan Period3End = new TimeSpan(11, 50, 0);
            TimeSpan Period4Start = new TimeSpan(11, 55, 0);
            TimeSpan Period4End = new TimeSpan(12, 45, 0);
            TimeSpan Period5Start = new TimeSpan(13, 25, 0);
            TimeSpan Period5End = new TimeSpan(14, 15, 0);
            TimeSpan Period6Start = new TimeSpan(14, 20, 0);
            TimeSpan Period6End = new TimeSpan(15, 05, 0);
            TimeSpan now = DateTime.Now.TimeOfDay;

            current.Opacity = 100;

            if ((now >= TutorialStart) && (now <= TutorialEnd))
            {
                current.Margin = new Thickness(0, 0, 0, 0);
            }

            else if ((now >= Period1Start) && (now <= Period1End))
            {
                current.Margin = new Thickness(72, 0, 0, 0);
            }

            else if ((now >= Period2Start) && (now <= Period2End))
            {
                current.Margin = new Thickness(144, 0, 0, 0);
            }

            else if ((now >= Period3Start) && (now <= Period3End))
            {
                current.Margin = new Thickness(216, 0, 0, 0);
            }

            else if ((now >= Period4Start) && (now <= Period4End))
            {
                current.Margin = new Thickness(288, 0, 0, 0);
            }

            else if ((now >= Period5Start) && (now <= Period5End))
            {
                current.Margin = new Thickness(360, 0, 0, 0);
            }

            else if((now >= Period6Start) && (now <= Period6End))
            {
                current.Margin = new Thickness(432, 0, 0, 0);
            }

            else
            {
                current.Opacity = 0;
            }
        }
        
        private void Diary_Clicked(object sender, RoutedEventArgs e)
        {
            HubFrame.Navigate(new Uri("Diary.xaml", UriKind.Relative));
        }

        private void Map_Clicked(object sender, RoutedEventArgs e)
        {
            HubFrame.Navigate(new Uri("Map.xaml", UriKind.Relative));

        }

        private void Timetable_Clicked(object sender, RoutedEventArgs e)
        {
            HubFrame.Navigate(new Uri("Timetable.xaml", UriKind.Relative));
        }

        private void Sport_Buton_clicked(object sender, RoutedEventArgs e)
        {
            HubFrame.Navigate(new Uri("Sports.xaml", UriKind.Relative));
        }

        private void HubFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void Nexus_clicked(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://nexus.ccgs.wa.edu.au/");
        }
    }
}

