using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace Learn_CSharp.Selenium
{
    internal class LearnBrowserCommands
    {

        static void Main(string[] args)
        {
            // Initialize WebDriver
            ChromeDriver driver = new ChromeDriver();

            try
            {
                // Open a URL
                driver.Navigate().GoToUrl("http://leaftaps.com/opentaps/control/main");

                // Maximize browser window
                driver.Manage().Window.Maximize();

                // Print the title of the page
                Console.WriteLine("Page Title: " + driver.Title);

                // Print the current URL
                Console.WriteLine("Current URL: " + driver.Url);

                // Refresh the page
                driver.Navigate().Refresh();

                // Navigate to another URL
                driver.Navigate().GoToUrl("https://www.google.com");

                // Navigate back
                driver.Navigate().Back();

                // Navigate forward
                driver.Navigate().Forward();
            }
            finally
            {
                // Close the browser
                driver.Quit();
            }
        }

    }
}
