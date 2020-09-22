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
            if (Directory.Exists(login))
            {
                this.Close();
                return;
            }
            DirectoryInfo di = Directory.CreateDirectory(login);



            this.Close();
        }
    }
}
