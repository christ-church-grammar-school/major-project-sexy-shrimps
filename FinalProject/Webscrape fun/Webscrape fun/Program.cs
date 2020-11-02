using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Edge;
using System.Text;
using System.IO;

namespace Webscrape_fun
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Manage().Window.Minimize();
            driver.Navigate().GoToUrl(@"https://nexus.ccgs.wa.edu.au/calendar/week");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(0);
            driver.FindElement(By.CssSelector(".fc-customExport-button")).Click();
            driver.FindElement(By.CssSelector(".radiolist > label:nth-child(6)")).Click();
            driver.FindElement(By.CssSelector("ul.flex-list:nth-child(4) > li:nth-child(1) > button:nth-child(1)")).Click();
            driver.FindElement(By.CssSelector(".component-action > section:nth-child(1) > button:nth-child(1)")).Click();
            var link = driver.FindElement(By.CssSelector("#reveal-modal-1 > textarea:nth-child(2)"));
            driver.Navigate().GoToUrl($@"{link}");
            //string r = "../../Users/" + "Results.txt";

            //DirectoryInfo di = Directory.CreateDirectory(r);

            // File.WriteAllText("result.txt", r);

            //driver.FindElement(By.XPath("//*[@id='export - timetableday']")).Click();

            // driver.FindElement(By.XPath("/html/body/div[6]/form/ul/li[2]/input")).Click();



        }
    }
}
