using System;
using System.IO;
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
using System.Windows.Shapes;


namespace FinalProject
{
    /// <summary>
    /// Interaction logic for UsInfo.xaml
    /// </summary>
    public partial class UsInfo : Window
    {
        public UsInfo()
        {
            InitializeComponent();
            
        }

 
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
 
        private void save_clicked(object sender, RoutedEventArgs e)
        {
            string login = "../../Users/" + student_id.Text;
            string diary = "../../Users/" + student_id.Text + "/diary";
            string student_path = "../../Users/" + student_id.Text + "/student.txt";
            string studentpath_color = "../../Users/" + student_id.Text + "/color.txt";
            string studentpath_sport = "../../Users/" + student_id.Text + "/sport.txt";

            
            if (Directory.Exists(login))
            {
                this.Close();
                return;
            }
            DirectoryInfo di = Directory.CreateDirectory(login);
            DirectoryInfo di2 = Directory.CreateDirectory(diary);
            if (!File.Exists(student_path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(student_path))
                {
                    sw.WriteLine(student_id.Text);
                    sw.WriteLine(student_password.Text);
                    sw.WriteLine("");
                    sw.WriteLine(student_name.Text);
                    sw.WriteLine("");

                    sw.WriteLine("1");
                    sw.WriteLine(AA.Text);
                    sw.WriteLine(BA.Text);
                    sw.WriteLine(CA.Text);
                    sw.WriteLine(DA.Text);
                    sw.WriteLine(EA.Text);
                    sw.WriteLine(FA.Text);
                    sw.WriteLine(GA.Text);

                    sw.WriteLine("2");
                    sw.WriteLine(AB.Text);
                    sw.WriteLine(BB.Text);
                    sw.WriteLine(CB.Text);
                    sw.WriteLine(DB.Text);
                    sw.WriteLine(EB.Text);
                    sw.WriteLine(FB.Text);
                    sw.WriteLine(GB.Text);

                    sw.WriteLine("3");
                    sw.WriteLine(AC.Text);
                    sw.WriteLine(BC.Text);
                    sw.WriteLine(CC.Text);
                    sw.WriteLine(DC.Text);
                    sw.WriteLine(EC.Text);
                    sw.WriteLine(FC.Text);
                    sw.WriteLine(GC.Text);

                    sw.WriteLine("4");
                    sw.WriteLine(AD.Text);
                    sw.WriteLine(BD.Text);
                    sw.WriteLine(CD.Text);
                    sw.WriteLine(DD.Text);
                    sw.WriteLine(ED.Text);
                    sw.WriteLine(FD.Text);
                    sw.WriteLine(GD.Text);

                    sw.WriteLine("5");
                    sw.WriteLine(AE.Text);
                    sw.WriteLine(BE.Text);
                    sw.WriteLine(CE.Text);
                    sw.WriteLine(DE.Text);
                    sw.WriteLine(EE.Text);
                    sw.WriteLine(FE.Text);
                    sw.WriteLine(GE.Text);

                    sw.WriteLine("6");
                    sw.WriteLine(AF.Text);
                    sw.WriteLine(BF.Text);
                    sw.WriteLine(CF.Text);
                    sw.WriteLine(DF.Text);
                    sw.WriteLine(EF.Text);
                    sw.WriteLine(FF.Text);
                    sw.WriteLine(GF.Text);

                    sw.WriteLine("7");
                    sw.WriteLine(AG.Text);
                    sw.WriteLine(BG.Text);
                    sw.WriteLine(CG.Text);
                    sw.WriteLine(DG.Text);
                    sw.WriteLine(EG.Text);
                    sw.WriteLine(FG.Text);
                    sw.WriteLine(GG.Text);

                    sw.WriteLine("8");
                    sw.WriteLine(AH.Text);
                    sw.WriteLine(BH.Text);
                    sw.WriteLine(CH.Text);
                    sw.WriteLine(DH.Text);
                    sw.WriteLine(EH.Text);
                    sw.WriteLine(FH.Text);
                    sw.WriteLine(GH.Text);

                    sw.WriteLine("9");
                    sw.WriteLine(AI.Text);
                    sw.WriteLine(BI.Text);
                    sw.WriteLine(CI.Text);
                    sw.WriteLine(DI.Text);
                    sw.WriteLine(EI.Text);
                    sw.WriteLine(FI.Text);
                    sw.WriteLine(GI.Text);

                    sw.WriteLine("10");
                    sw.WriteLine(AJ.Text);
                    sw.WriteLine(BJ.Text);
                    sw.WriteLine(CJ.Text);
                    sw.WriteLine(DJ.Text);
                    sw.WriteLine(EJ.Text);
                    sw.WriteLine(FJ.Text);
                    sw.WriteLine(GJ.Text);
                }
            }

            // Open the file to read from.
            using (StreamReader sr = File.OpenText(student_path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
            if (!File.Exists(studentpath_color))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(studentpath_color))
                {
                    sw.WriteLine("#ffe0cc"+Environment.NewLine+ "#ccffcc" + Environment.NewLine+ "#ffccf5"+ Environment.NewLine+ "#f5ffcc"+ Environment.NewLine+ "#ccffe0"+ Environment.NewLine +"#ffcce0"+ Environment.NewLine+ "#ccccff"+ Environment.NewLine+ "#ffe0cc"+ Environment.NewLine+ "#cce0ff"+ Environment.NewLine+ "#ffcce0"+ Environment.NewLine+ "#ccccff"+ Environment.NewLine+"#ccffcc"+ Environment.NewLine+ "#f5ffcc"+Environment.NewLine+ "#ffccf5"+ Environment.NewLine+ "#ffe0cc"+ Environment.NewLine+ "#ffccf5"+ Environment.NewLine+ "#f5ffcc"+ Environment.NewLine+ "#ccffe0"+Environment.NewLine+ "#cce0ff"+ Environment.NewLine+ "#ccfff5"+ Environment.NewLine + "#ccffcc" + Environment.NewLine + "#ffe0cc" + Environment.NewLine + "#ffe0cc" + Environment.NewLine + "#ccccff" + Environment.NewLine + "#f5ffcc" + Environment.NewLine + "#cce0ff" + Environment.NewLine + "#ccfff5" + Environment.NewLine + "#ccffe0" + Environment.NewLine + "#ffe0cc" + Environment.NewLine + "#ccffcc" + Environment.NewLine + "#ffcce0" + Environment.NewLine + "#ccffe0" + Environment.NewLine + "#ccccff" + Environment.NewLine + "#e4e6e4" + Environment.NewLine + "#e4e6e4" + Environment.NewLine + "#ffe0cc" + Environment.NewLine + "#ccffcc" + Environment.NewLine + "#cce0ff" + Environment.NewLine + "#f5ffcc" + Environment.NewLine + "#ffcce0" + Environment.NewLine + "#ccccff" + Environment.NewLine + "#ffcce0" + Environment.NewLine + "#cce0ff" + Environment.NewLine + "#ccffe0" + Environment.NewLine + "#ccfff5"  + Environment.NewLine + "#ffe0cc" + Environment.NewLine + "#ccccff" + Environment.NewLine + "#ccffe0" + Environment.NewLine + "#f5ffcc"+ Environment.NewLine + "#ccffcc"+ Environment.NewLine + "#e4e6e4"+ Environment.NewLine + "#e4e6e4" + Environment.NewLine + "#e4e6e4" + Environment.NewLine + "#e4e6e4" + Environment.NewLine + "#e4e6e4" + Environment.NewLine + "#e4e6e4" + Environment.NewLine + "#e4e6e4" + Environment.NewLine + "#e4e6e4" + Environment.NewLine + "#e4e6e4" + Environment.NewLine + "#e4e6e4" + Environment.NewLine + "#e4e6e4" + Environment.NewLine + "#e4e6e4" + Environment.NewLine + "#e4e6e4" + Environment.NewLine + "#e4e6e4" + Environment.NewLine + "#e4e6e4" + Environment.NewLine + "#e4e6e4" + Environment.NewLine + "#e4e6e4" + Environment.NewLine + "#e4e6e4" + Environment.NewLine + "#e4e6e4" + Environment.NewLine + "#e4e6e4");
                }
            }

            if (!File.Exists(studentpath_sport))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(studentpath_sport))
                {
                    sw.WriteLine(summersport.Text + Environment.NewLine + summersporteam.Text + Environment.NewLine + "" + Environment.NewLine + wintersport.Text + Environment.NewLine + wintersportteam.Text);
                }
            }

            // Open the file to read from.
            using (StreamReader sr = File.OpenText(studentpath_color))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }




            this.Close();
        }
    }
}
