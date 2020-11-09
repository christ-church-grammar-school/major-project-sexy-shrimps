using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

using System.Windows.Threading;
using System.IO;

namespace FinalProject
{
    /// <summary>
    /// Interaction logic for Map.xaml
    /// </summary>
    public partial class Map : Page
    {
        public Map()
        {
            InitializeComponent();
        }

        private void imagesComboBox_SelectionChanged(object sender, RoutedEventArgs ee)
        {
            if (selectionComboBox.SelectedItem != null)
            {
                ComboBoxItem comboItem = (ComboBoxItem)(selectionComboBox.ItemContainerGenerator.ContainerFromIndex(selectionComboBox.SelectedIndex));
                string comboImg = comboItem.Content.ToString();

                if (comboImg == "Select All")
                {
                    all.Opacity = 100;
                }

                else
                {
                    all.Opacity = 0;

                    string path = "../../user.txt";
                    string user = File.ReadLines(path).First();
                    string path2 = "../../Users/" + user + "/classes.txt";

                    for (int z = 0; z < File.ReadLines(path2).Count(); z++)
                    {
                        string cls = File.ReadLines(path2).ElementAt(z);
                        if (cls == "Pool") { pool.Opacity = 100; }
                        else if (cls == "Senior Oval") { senior.Opacity = 100; }
                        else if (cls == "Cricket Nets") { nets.Opacity = 100; }
                        else if (cls == "Junior Oval") { junior.Opacity = 100; }
                        else if (cls == "B") { b.Opacity = 100; }
                        else if (cls == "F") { f.Opacity = 100; }
                        else if (cls == "J") { j.Opacity = 100; }
                        else if (cls == "I") { i.Opacity = 100; }
                        else if (cls == "H") { h.Opacity = 100; }
                        else if (cls == "E") { e.Opacity = 100; }
                        else if (cls == "C") { c.Opacity = 100; }
                        else if (cls == "G") { g.Opacity = 100; }
                        else if (cls == "D") { d.Opacity = 100; }
                        else if (cls == "V") { v.Opacity = 100; }
                        else if (cls == "W") { w.Opacity = 100; }
                        else if (cls == "K") { k.Opacity = 100; }
                        else if (cls == "L") { l.Opacity = 100; }
                        else if (cls == "Q") { q.Opacity = 100; }
                        else if (cls == "M") { m.Opacity = 100; }
                        else if (cls == "T") { t.Opacity = 100; }
                        else if (cls == "S") { s.Opacity = 100; }
                        else if (cls == "R") { r.Opacity = 100; }
                        else if (cls == "P") { p.Opacity = 100; }
                        else if (cls == "N") { n.Opacity = 100; }
                    }
                }
            }
        }
        private void Return_Clicked(object sender, RoutedEventArgs e)
        {
            MapFrame.Navigate(new Uri("Hub.xaml", UriKind.Relative));
        }
        private void MapFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void Back_Clicked(object sender, RoutedEventArgs e)
        {
            MapFrame.Navigate(new Uri("Hub.xaml", UriKind.Relative));
        }
    }
}
