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
    /// Interaction logic for Timetable.xaml
    /// </summary>
    public partial class Timetable : Page
    { 
        public Timetable()
        {
            InitializeComponent();
            LoadSubjects();
            LoadColors();

            DateTime dateValue = DateTime.Now;
            int dayOfWeek = (int)dateValue.DayOfWeek;

            if (dayOfWeek != 0 && dayOfWeek != 6)
            {
                box.Opacity = 100;
                LoadDay();
            }
            else
            {
                box.Opacity = 0;
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

        private void LoadDay()
        {
            int day = GetDayOfFortnight();
            double dist = (day - 1) * 76.7;

            box.Margin = new Thickness(dist,0,0,0);
        }
        private void LoadSubjects()
        {
            string path = "../../user.txt";
            string user = File.ReadLines(path).First();
            string path2 = "../../Users/" + user + "/student.txt";

            AA.Content = File.ReadLines(path2).ElementAt(6);
            BA.Content = File.ReadLines(path2).ElementAt(7);
            CA.Content = File.ReadLines(path2).ElementAt(8);
            DA.Content = File.ReadLines(path2).ElementAt(9);
            EA.Content = File.ReadLines(path2).ElementAt(10);
            FA.Content = File.ReadLines(path2).ElementAt(11);
            GA.Content = File.ReadLines(path2).ElementAt(12);

            AB.Content = File.ReadLines(path2).ElementAt(14);
            BB.Content = File.ReadLines(path2).ElementAt(15);
            CB.Content = File.ReadLines(path2).ElementAt(16);
            DB.Content = File.ReadLines(path2).ElementAt(17);
            EB.Content = File.ReadLines(path2).ElementAt(18);
            FB.Content = File.ReadLines(path2).ElementAt(19);
            GB.Content = File.ReadLines(path2).ElementAt(20);

            AC.Content = File.ReadLines(path2).ElementAt(22);
            BC.Content = File.ReadLines(path2).ElementAt(23);
            CC.Content = File.ReadLines(path2).ElementAt(24);
            DC.Content = File.ReadLines(path2).ElementAt(25);
            EC.Content = File.ReadLines(path2).ElementAt(26);
            FC.Content = File.ReadLines(path2).ElementAt(27);
            GC.Content = File.ReadLines(path2).ElementAt(28);

            AD.Content = File.ReadLines(path2).ElementAt(30);
            BD.Content = File.ReadLines(path2).ElementAt(31);
            CD.Content = File.ReadLines(path2).ElementAt(32);
            DD.Content = File.ReadLines(path2).ElementAt(33);
            ED.Content = File.ReadLines(path2).ElementAt(34);
            FD.Content = File.ReadLines(path2).ElementAt(35);
            GD.Content = File.ReadLines(path2).ElementAt(36);

            AE.Content = File.ReadLines(path2).ElementAt(38);
            BE.Content = File.ReadLines(path2).ElementAt(39);
            CE.Content = File.ReadLines(path2).ElementAt(40);
            DE.Content = File.ReadLines(path2).ElementAt(41);
            EE.Content = File.ReadLines(path2).ElementAt(42);
            FE.Content = File.ReadLines(path2).ElementAt(43);
            GE.Content = File.ReadLines(path2).ElementAt(44);

            AF.Content = File.ReadLines(path2).ElementAt(46);
            BF.Content = File.ReadLines(path2).ElementAt(47);
            CF.Content = File.ReadLines(path2).ElementAt(48);
            DF.Content = File.ReadLines(path2).ElementAt(49);
            EF.Content = File.ReadLines(path2).ElementAt(50);
            FF.Content = File.ReadLines(path2).ElementAt(51);
            GF.Content = File.ReadLines(path2).ElementAt(52);

            AG.Content = File.ReadLines(path2).ElementAt(54);
            BG.Content = File.ReadLines(path2).ElementAt(55);
            CG.Content = File.ReadLines(path2).ElementAt(56);
            DG.Content = File.ReadLines(path2).ElementAt(57);
            EG.Content = File.ReadLines(path2).ElementAt(58);
            FG.Content = File.ReadLines(path2).ElementAt(59);
            GG.Content = File.ReadLines(path2).ElementAt(60);

            AH.Content = File.ReadLines(path2).ElementAt(62);
            BH.Content = File.ReadLines(path2).ElementAt(63);
            CH.Content = File.ReadLines(path2).ElementAt(64);
            DH.Content = File.ReadLines(path2).ElementAt(65);
            EH.Content = File.ReadLines(path2).ElementAt(66);
            FH.Content = File.ReadLines(path2).ElementAt(67);
            GH.Content = File.ReadLines(path2).ElementAt(68);

            AI.Content = File.ReadLines(path2).ElementAt(70);
            BI.Content = File.ReadLines(path2).ElementAt(71);
            CI.Content = File.ReadLines(path2).ElementAt(72);
            DI.Content = File.ReadLines(path2).ElementAt(73);
            EI.Content = File.ReadLines(path2).ElementAt(74);
            FI.Content = File.ReadLines(path2).ElementAt(75);
            GI.Content = File.ReadLines(path2).ElementAt(76);

            AJ.Content = File.ReadLines(path2).ElementAt(78);
            BJ.Content = File.ReadLines(path2).ElementAt(79);
            CJ.Content = File.ReadLines(path2).ElementAt(80);
            DJ.Content = File.ReadLines(path2).ElementAt(81);
            EJ.Content = File.ReadLines(path2).ElementAt(82);
            FJ.Content = File.ReadLines(path2).ElementAt(83);
            GJ.Content = File.ReadLines(path2).ElementAt(84);
        }

        private void LoadColors()
        {
            string path = "../../user.txt";
            string user = File.ReadLines(path).First();
            string path2 = "../../Users/" + user + "/color.txt";

            AAA.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path2).ElementAt(0));
            AAB.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path2).ElementAt(1));
            AAC.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path2).ElementAt(2));
            AAD.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path2).ElementAt(3));
            AAE.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path2).ElementAt(4));
            AAF.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path2).ElementAt(5));
            AAG.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path2).ElementAt(6));

            ABA.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path2).ElementAt(7));
            ABB.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path2).ElementAt(8));
            ABC.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path2).ElementAt(9));
            ABD.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path2).ElementAt(10));
            ABE.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path2).ElementAt(11));
            ABF.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path2).ElementAt(12));
            ABG.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path2).ElementAt(13));

            ACA.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path2).ElementAt(14));
            ACB.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path2).ElementAt(15));
            ACC.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path2).ElementAt(16));
            ACD.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path2).ElementAt(17));
            ACE.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path2).ElementAt(18));
            ACF.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path2).ElementAt(19));
            ACG.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path2).ElementAt(20));

            ADA.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path2).ElementAt(21));
            ADB.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path2).ElementAt(22));
            ADC.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path2).ElementAt(23));
            ADD.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path2).ElementAt(24));
            ADE.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path2).ElementAt(25));
            ADF.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path2).ElementAt(26));
            ADG.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path2).ElementAt(27));

            AEA.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path2).ElementAt(28));
            AEB.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path2).ElementAt(29));
            AEC.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path2).ElementAt(30));
            AED.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path2).ElementAt(31));
            AEE.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path2).ElementAt(32));
            AEF.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path2).ElementAt(33));
            AEG.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path2).ElementAt(34));

            AFA.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path2).ElementAt(35));
            AFB.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path2).ElementAt(36));
            AFC.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path2).ElementAt(37));
            AFD.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path2).ElementAt(38));
            AFE.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path2).ElementAt(39));
            AFF.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path2).ElementAt(40));
            AFG.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path2).ElementAt(41));

            AGA.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path2).ElementAt(42));
            AGB.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path2).ElementAt(43));
            AGC.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path2).ElementAt(44));
            AGD.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path2).ElementAt(45));
            AGE.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path2).ElementAt(46));
            AGF.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path2).ElementAt(47));
            AGG.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path2).ElementAt(48));

            AHA.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path2).ElementAt(49));
            AHB.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path2).ElementAt(50));
            AHC.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path2).ElementAt(51));
            AHD.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path2).ElementAt(52));
            AHE.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path2).ElementAt(53));
            AHF.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path2).ElementAt(54));
            AHG.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path2).ElementAt(55));

            AIA.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path2).ElementAt(56));
            AIB.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path2).ElementAt(57));
            AIC.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path2).ElementAt(58));
            AID.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path2).ElementAt(59));
            AIE.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path2).ElementAt(60));
            AIF.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path2).ElementAt(61));
            AIG.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path2).ElementAt(62));

            AJA.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path2).ElementAt(63));
            AJB.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path2).ElementAt(64));
            AJC.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path2).ElementAt(65));
            AJD.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path2).ElementAt(66));
            AJE.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path2).ElementAt(67));
            AJF.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path2).ElementAt(68));
            AJG.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(File.ReadLines(path2).ElementAt(69));
        }

        private void Return_Clicked(object sender, RoutedEventArgs e)
        {
            TimetableFrame.Navigate(new Uri("Hub.xaml", UriKind.Relative));
        }
        private void TimetableFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
