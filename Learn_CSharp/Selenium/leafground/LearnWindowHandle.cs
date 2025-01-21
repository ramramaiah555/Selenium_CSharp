using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace Learn_CSharp.Selenium.leafground
{
    internal class LearnWindowHandle
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            // Navigate to leafground
            driver.Navigate().GoToUrl("https://leafground.com/");

            // Maximize browser window
            driver.Manage().Window.Maximize();

            // Click Browse
            driver.FindElement(By.XPath("//span[text()='Browser']//parent::a")).Click();

            // Click Window
            driver.FindElement(By.XPath("//span[text()='Window']//parent::a")).Click();

            // Click Open
            driver.FindElement(By.XPath("//span[text()='Open']/parent::button")).Click();

            // Get all window handles
            var windowHandles = driver.WindowHandles;

            // Switch to the second window/tab
            driver.SwitchTo().Window(windowHandles[1]);

            Console.WriteLine("Current URL in new tab: " + driver.Url);

            // Switch back to the original window/tab
            driver.SwitchTo().Window(windowHandles[0]);
        }
    }
}
