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
using System.Globalization;

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

            DateTime date2 = DateTime.Now;

            

            string date = date2.ToString("dd-MM-yyyy");
            date_top.Text = date2.ToString("D");
            LoadTimetable(date2);



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
        }



        private void LoadTimetable(DateTime date)
        {
            int day = GetDayOfFortnight(date);
            TimetableDay2.Text = "Timetable - Day " + day.ToString();

            string path = "../../user.txt";
            string user = File.ReadLines(path).First();
            string path2 = "../../Users/" + user + ".txt";

            int i = 5;
            while (File.ReadLines(path2).ElementAt(i) != day.ToString())
            {
                i += 8;
            }

            sub1.Text = File.ReadLines(path2).ElementAt(i + 1);
            sub2.Text = File.ReadLines(path2).ElementAt(i + 2);
            sub3.Text = File.ReadLines(path2).ElementAt(i + 3);
            sub4.Text = File.ReadLines(path2).ElementAt(i + 4);
            sub5.Text = File.ReadLines(path2).ElementAt(i + 5);
            sub6.Text = File.ReadLines(path2).ElementAt(i + 6);
            sub7.Text = File.ReadLines(path2).ElementAt(i + 7);

            DateTime date3 = Convert.ToDateTime(date_top.Text);

            if (date3.DayOfWeek.ToString() == "Saturday" || date3.DayOfWeek.ToString() == "Sunday")
            {
                Weekend();
            }
            else
            {
                Weekday();
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

        public static int GetDayOfFortnight(DateTime date)
        {
            int weekOfYear = GetWeekOfYear(date) - 1;
            DateTime now = date;
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

        public void Weekend()
        {
            rect1.Opacity = 0;
            rect2.Opacity = 0;
            rect3.Opacity = 0;
            rect4.Opacity = 0;
            rect5.Opacity = 0;
            rect6.Opacity = 0;
            rect7.Opacity = 0;

            sub1.Opacity = 0;
            sub2.Opacity = 0;
            sub3.Opacity = 0;
            sub4.Opacity = 0;
            sub5.Opacity = 0;
            sub6.Opacity = 0;
            sub7.Opacity = 0;

            TimetableDay2.Opacity = 0;

            Button1.Opacity = 0;
            Button2.Opacity = 0;
            Button3.Opacity = 0;
            Button4.Opacity = 0;
            Button5.Opacity = 0;
            Button6.Opacity = 0;
            Button7.Opacity = 0;
        }

        private void Weekday()
        {
            rect1.Opacity = 1;
            rect2.Opacity = 1;
            rect3.Opacity = 1;
            rect4.Opacity = 1;
            rect5.Opacity = 1;
            rect6.Opacity = 1;
            rect7.Opacity = 1;

            sub1.Opacity = 1;
            sub2.Opacity = 1;
            sub3.Opacity = 1;
            sub4.Opacity = 1;
            sub5.Opacity = 1;
            sub6.Opacity = 1;
            sub7.Opacity = 1;

            TimetableDay2.Opacity = 1;

            Button1.Opacity = 0.25;
            Button2.Opacity = 0.25;
            Button3.Opacity = 0.25;
            Button4.Opacity = 0.25;
            Button5.Opacity = 0.25;
            Button6.Opacity = 0.25;
            Button7.Opacity = 0.25;
        }







        private void save(object sender, RoutedEventArgs e)
        {
            DateTime date2 = Convert.ToDateTime(date_top.Text);
            string date = date2.ToString("dd-MM-yyyy");
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
            DateTime date2 = Convert.ToDateTime(date_top.Text);
            string date = date2.ToString("dd-MM-yyyy");
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
            DiaryFrame.Navigate(new Uri("Hub.xaml", UriKind.Relative));
        }

        private void DiaryFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void Next(object sender, RoutedEventArgs e)
        {
            DateTime date4 = Convert.ToDateTime(date_top.Text);
            string date5 = date4.ToString("dd-MM-yyyy");
            string path2 = $"../../Diary/{date5}.txt";


            if (Diary.Text == "")
            {
                File.Delete(path2);
            }
            else
            {
                File.WriteAllText(path2, String.Empty);
                TextWriter tw = new StreamWriter(path2, true);
                tw.WriteLine(Diary.Text);
                tw.Close();
            }

            DateTime date3 = Convert.ToDateTime(date_top.Text);
            TimeSpan span = new TimeSpan(1, 0, 0, 0, 0);
            DateTime date2 = date3 + span;

            

            string date = date2.ToString("dd-MM-yyyy");
            date_top.Text = date2.ToString("D");
            LoadTimetable(date2);



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
        }

        private void Previous(object sender, RoutedEventArgs e)
        {
            DateTime date4 = Convert.ToDateTime(date_top.Text);
            string date5 = date4.ToString("dd-MM-yyyy");
            string path2 = $"../../Diary/{date5}.txt";


            if (Diary.Text == "")
            {
                File.Delete(path2);
            }
            else
            {
                File.WriteAllText(path2, String.Empty);
                TextWriter tw = new StreamWriter(path2, true);
                tw.WriteLine(Diary.Text);
                tw.Close();
            }

            DateTime date3 = Convert.ToDateTime(date_top.Text);
            TimeSpan span = new TimeSpan(1, 0, 0, 0, 0);
            DateTime date2 = date3 - span;
            

            string date = date2.ToString("dd-MM-yyyy");
            date_top.Text = date2.ToString("D");
            LoadTimetable(date2);



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
        }

        private void subj1(object sender, RoutedEventArgs e)
        {
            DateTime date3 = Convert.ToDateTime(date_top.Text);

            if (date3.DayOfWeek.ToString() != "Saturday" && date3.DayOfWeek.ToString() != "Sunday")
            {
                string subject = sub1.Text;
                Subject newpage = new Subject(subject);
                this.NavigationService.Navigate(newpage, subject);
            }
        }
        private void subj2(object sender, RoutedEventArgs e)
        {
            DateTime date3 = Convert.ToDateTime(date_top.Text);

            if (date3.DayOfWeek.ToString() != "Saturday" && date3.DayOfWeek.ToString() != "Sunday")
            {
                string subject = sub2.Text;
                Subject newpage = new Subject(subject);
                this.NavigationService.Navigate(newpage, subject);
            }

        }
        private void subj3(object sender, RoutedEventArgs e)
        {
            DateTime date3 = Convert.ToDateTime(date_top.Text);

            if (date3.DayOfWeek.ToString() != "Saturday" && date3.DayOfWeek.ToString() != "Sunday")
            {
                string subject = sub3.Text;
                Subject newpage = new Subject(subject);
                this.NavigationService.Navigate(newpage, subject);
            }

        }
        private void subj4(object sender, RoutedEventArgs e)
        {
            DateTime date3 = Convert.ToDateTime(date_top.Text);

            if (date3.DayOfWeek.ToString() != "Saturday" && date3.DayOfWeek.ToString() != "Sunday")
            {
                string subject = sub4.Text;
                Subject newpage = new Subject(subject);
                this.NavigationService.Navigate(newpage, subject);
            }

        }
        private void subj5(object sender, RoutedEventArgs e)
        {
            DateTime date3 = Convert.ToDateTime(date_top.Text);

            if (date3.DayOfWeek.ToString() != "Saturday" && date3.DayOfWeek.ToString() != "Sunday")
            {
                string subject = sub5.Text;
                Subject newpage = new Subject(subject);
                this.NavigationService.Navigate(newpage, subject);
            }

        }
        private void subj6(object sender, RoutedEventArgs e)
        {
            DateTime date3 = Convert.ToDateTime(date_top.Text);

            if (date3.DayOfWeek.ToString() != "Saturday" && date3.DayOfWeek.ToString() != "Sunday")
            {
                string subject = sub6.Text;
                Subject newpage = new Subject(subject);
                this.NavigationService.Navigate(newpage, subject);
            }
        }
        private void subj7(object sender, RoutedEventArgs e)
        {
            DateTime date3 = Convert.ToDateTime(date_top.Text);

            if (date3.DayOfWeek.ToString() != "Saturday" && date3.DayOfWeek.ToString() != "Sunday")
            {
                string subject = sub7.Text;
                Subject newpage = new Subject(subject);
                this.NavigationService.Navigate(newpage, subject);
            }
        }
    }
}
