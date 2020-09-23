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
using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using AngleSharp.Html.Parser;
using AngleSharp.Text;
using System.Net.Http;
using System.Threading;
using System.Diagnostics;
using System.Net;
using HtmlAgilityPack;

namespace FinalProject
{
    /// <summary>
    /// Interaction logic for Sports.xaml
    /// </summary>
    public partial class Sports : Page
    {
        public Sports()
        {
            InitializeComponent();

            Navigate();
        }

        

        private void Navigate()
        {
            

            string pathuser = "../../user.txt";
            string user = File.ReadLines(pathuser).First();
            string path = $"../../Users/{user}/sport.txt";
            string sport = File.ReadLines(path).First();
            string team = File.ReadLines(path).Skip(1).Take(1).First();

            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load("http://sport.ccgs.wa.edu.au/Fixtures_Teams.asp?Id=28729");

            foreach (HtmlNode node in doc.DocumentNode.SelectNodes("//a[@href]"))
            {       
                if (node.InnerText == sport)
                {
                    string hrefValue = node.GetAttributeValue("href", string.Empty);
                    HtmlWeb web2 = new HtmlWeb();
                    HtmlDocument doc2 = web2.Load($"http://sport.ccgs.wa.edu.au/{hrefValue}");


                    foreach (HtmlNode node2 in doc2.DocumentNode.SelectNodes("//a[@href]"))
                    {
                        if (node2.InnerText == team)
                        {
                            string hrefValue2 = node2.GetAttributeValue("href", string.Empty);

                            ScrapeWebsite($"http://sport.ccgs.wa.edu.au/{hrefValue2}");
                        }
                    }
                }
            }
        }


        private void ScrapeWebsite(string link)
        {
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load(link);

            

            HtmlNode[] date = doc.DocumentNode.SelectSingleNode("//tr[@id]")
                 .SelectNodes(".//td[@style='white-space:nowrap; text-align:center']").ToArray();
            HtmlNode[] venue = doc.DocumentNode.SelectSingleNode("//tr[@id]")
                 .SelectNodes(".//a[@class='pu_MapLink']").ToArray();
            HtmlNode[] opponent = doc.DocumentNode.SelectSingleNode("//tr[@id]")
                 .SelectNodes(".//span[@class='FixtureListOpponent']").ToArray();
            HtmlNode[] result = doc.DocumentNode.SelectSingleNode("//tr[@id]")
                 .SelectNodes(".//td[@style='white-space:nowrap']").ToArray();

            List<string> date2 = date[0].InnerHtml.Split(new string[] { "<br>" }, StringSplitOptions.None).Select(s => HtmlNode.CreateNode($"<span>{s}</span>").InnerText).ToList();
            List<string> result2 = result[0].InnerHtml.Split(new string[] { "<br>" }, StringSplitOptions.None).Select(s => HtmlNode.CreateNode($"<span>{s}</span>").InnerText).ToList();

            date_text.Text = $"{date2[0]}\n{date2[1]}\n{date2[2]}";
            venue_text.Text = venue[0].GetAttributeValue("title", string.Empty);
            opponent_text.Text = opponent[0].InnerText;
            result_text.Text = $"{result2[0]}\n{result2[1]}";
        }

        private void Return_Clicked(object sender, RoutedEventArgs e)
        {
            SportsFrame.Navigate(new Uri("Hub.xaml", UriKind.Relative));
        }
        private void SportsFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
