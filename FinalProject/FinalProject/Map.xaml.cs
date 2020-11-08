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
        private void imagesComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem comboItem = (ComboBoxItem)(selectionComboBox.ItemContainerGenerator.ContainerFromIndex(selectionComboBox.SelectedIndex));
            string comboSelection = comboItem.Content.ToString();

            if (comboSelection == "Select All")
            {
                all.Opacity = 100;
            }
            else if (comboSelection == "My Classes")
            {

            }
            else if (comboSelection == "Today's Classes")
            {

            }
            else
            {

            }
        }
    }
}
