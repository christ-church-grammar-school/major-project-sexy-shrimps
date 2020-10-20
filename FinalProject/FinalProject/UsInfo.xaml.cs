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
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

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
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "nexus.ccgs.wa.edu.au";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait(TimeSpan.FromSeconds(10));
        }

 
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
 
        private void save_clicked(object sender, RoutedEventArgs e)
        {
            string login = "../../Users/" + student_id.Text;
            string student_path = "../../Users/" + student_id.Text + "/student.txt";
            string studentpath_color = "../../Users/" + student_id.Text + "/color.txt";
            if (Directory.Exists(login))
            {
                this.Close();
                return;
            }
            DirectoryInfo di = Directory.CreateDirectory(login);
            if (!File.Exists(student_path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(student_path))
                {
                    sw.WriteLine(student_id.Text);
                    sw.WriteLine(student_password.Text);
                    sw.WriteLine("");
                    sw.WriteLine(student_name.Text);

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
                    sw.WriteLine("#ffe0cc"+Environment.NewLine+ "#ccffcc" + Environment.NewLine+ "#ffccf5"+ Environment.NewLine+ "#f5ffcc"+ Environment.NewLine+ "#ccffe0"+ Environment.NewLine +"#ffcce0"+ Environment.NewLine+ "#ccccff"+ Environment.NewLine+ "#ffe0cc"+ Environment.NewLine+ "#cce0ff"+ Environment.NewLine+ "#ffcce0"+ Environment.NewLine+ "#ccccff"+ Environment.NewLine+"#ccffcc"+ Environment.NewLine+ "#f5ffcc+"+Environment.NewLine+ "#ffccf5"+ Environment.NewLine+ "#ffe0cc"+ Environment.NewLine+ "#ffccf5"+ Environment.NewLine+ "#f5ffcc"+ Environment.NewLine+ "#ccffe0"+Environment.NewLine+ "#cce0ff"+ Environment.NewLine+ "#ccfff5"+ Environment.NewLine + "#ccffcc" + Environment.NewLine + "#ffe0cc" + Environment.NewLine + "#ffe0cc" + Environment.NewLine + "#ccccff" + Environment.NewLine + "f5ffcc" + Environment.NewLine + "#cce0ff" + Environment.NewLine + "#ccfff5" + Environment.NewLine + "ccffe0" + Environment.NewLine + "#ffe0cc" + Environment.NewLine + "#ccffcc" + Environment.NewLine + "#ffcce0" + Environment.NewLine + "#ccffe0" + Environment.NewLine + "#ccccff" + Environment.NewLine + "#e4e6e4" + Environment.NewLine + "#e4e6e4" + Environment.NewLine + "#ffe0cc" + Environment.NewLine + "#ccffcc" + Environment.NewLine + "#cce0ff" + Environment.NewLine + "#f5ffcc" + Environment.NewLine + "#ffcce0" + Environment.NewLine + "#ccccff" + Environment.NewLine + "#ffcce0" + Environment.NewLine + "#cce0ff" + Environment.NewLine + "#ccffe0" + Environment.NewLine + "#ccfff5"  + Environment.NewLine + "#ffe0cc" + Environment.NewLine + "#ccccff" + Environment.NewLine + "#ccffe0" + Environment.NewLine + "#f5ffcc"+ Environment.NewLine + "#ccffcc"+ Environment.NewLine + "#e4e6e4"+ Environment.NewLine + "#e4e6e4");



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
