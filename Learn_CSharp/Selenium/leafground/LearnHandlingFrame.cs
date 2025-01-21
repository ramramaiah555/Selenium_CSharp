using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace Learn_CSharp.Selenium.leafground
{
    internal class LearnHandlingFrame
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

            // Click Frame
            driver.FindElement(By.XPath("//span[text()='Frame']//parent::a")).Click();

            // Switch to frame by index
            driver.SwitchTo().Frame(0);

            //  Click Me (Inside frame)
            IWebElement clickMe = driver.FindElement(By.XPath("//button[@id='Click']"));
            clickMe.Click();
            string verifyMsg = clickMe.Text;
            Console.WriteLine("Success Message :- " +verifyMsg);
            
            // Switch back to the default content
            driver.SwitchTo().DefaultContent();



        }
    }
}
