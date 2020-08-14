﻿using System;
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

            WelcomeUser();
            LoadTimetable();
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
            for (int i = 0; i < 7; i++)
            {
                string path = "../../user.txt";
                string user = File.ReadLines(path).First();
                string path2 = "../../Users/" + user + ".txt";

                sub1.Text = File.ReadLines(path2).ElementAt(5);
                sub2.Text = File.ReadLines(path2).ElementAt(6);
                sub3.Text = File.ReadLines(path2).ElementAt(7);
                sub4.Text = File.ReadLines(path2).ElementAt(8);
                sub5.Text = File.ReadLines(path2).ElementAt(9);
                sub6.Text = File.ReadLines(path2).ElementAt(10);
                sub7.Text = File.ReadLines(path2).ElementAt(11);
            }
        }
        private void Diary_Clicked(object sender, RoutedEventArgs e)
        {
            HubFrame.Navigate(new Uri("Diary.xaml", UriKind.Relative));
        }
        private void HubFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }

    }
}

