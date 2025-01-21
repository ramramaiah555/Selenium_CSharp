using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace Learn_CSharp.Selenium
{
    internal class LearnWebelementInteraction
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

                // Locate elements and interact with them
                IWebElement username = driver.FindElement(By.Id("username"));
                IWebElement password = driver.FindElement(By.Id("password"));
                IWebElement loginButton = driver.FindElement(By.XPath("//input[@value='Login']"));

                // Type text into input fields
                username.SendKeys("demosalesmanager");
                password.SendKeys("crmsfa");

                // Click the login button
                loginButton.Click();

                // Retrieve and print text from an element
                IWebElement welcomeMessage = driver.FindElement(By.XPath("//a[contains(text(),'CRM')]"));
                Console.WriteLine("Message: " + welcomeMessage.Text);
            }
            finally
            {
                // Close the browser
                driver.Quit();
            }
        }
    }
}
