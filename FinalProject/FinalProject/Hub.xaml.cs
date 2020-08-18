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

            string path2 = "../../Users/" + user + ".txt";
            string name = File.ReadLines(path2).ElementAt(3);
            welcome.Text = welcome.Text + name;
        }
        private void LoadTimetable()
        {
            int day = GetDayOfFortnight();
            TimetableDay.Text = "Timetable - Day " + day.ToString();

            string path = "../../user.txt";
            string user = File.ReadLines(path).First();
            string path2 = "../../Users/" + user + ".txt";

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
        private void Diary_Clicked(object sender, RoutedEventArgs e)
        {
            HubFrame.Navigate(new Uri("Diary.xaml", UriKind.Relative));
        }
        private void Sport_Buton_clicked(object sender, RoutedEventArgs e)
        {
            HubFrame.Navigate(new Uri("Sports.xaml", UriKind.Relative));
        }
        private void HubFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}

