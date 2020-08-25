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
    /// Interaction logic for Timetable.xaml
    /// </summary>
    public partial class Timetable : Page
    { 
        public Timetable()
        {
            InitializeComponent();
            LoadTimetable();
        }
        private void LoadTimetable()
        {
            string path = "../../user.txt";
            string user = File.ReadLines(path).First();
            string path2 = "../../Users/" + user + ".txt";

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

        private void Return_Clicked(object sender, RoutedEventArgs e)
        {
            TimetableFrame.Navigate(new Uri("Hub.xaml", UriKind.Relative));
        }
        private void TimetableFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
