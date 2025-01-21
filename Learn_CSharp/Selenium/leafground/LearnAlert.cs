using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace Learn_CSharp.Selenium.leafground
{
    internal class LearnAlert
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://leafground.com/");

            // Click Browse
            driver.FindElement(By.XPath("//span[text()='Browser']//parent::a")).Click();

            // Click Alert
            driver.FindElement(By.XPath("//span[text()='Alert']//parent::a")).Click();

            // Click Alert (Promt Dialog) show button
            driver.FindElement(By.XPath("(//h5[contains(text(),'Prompt Dialog')]//following::span[text()='Show'])[1]")).Click();

            // Switch to alert
            IAlert alert = driver.SwitchTo().Alert();

            // Get alert text
            Console.WriteLine("Alert Text: " + alert.Text);

            // Enter text in input field
            alert.SendKeys("Ramkumar");

            // Accept the alert
            alert.Accept();

            // Dismiss the alert
            //alert.Dismiss();

            string enteredName = driver.FindElement(By.XPath("//span[@id='confirm_result']")).Text;
            Console.WriteLine("Entered Name : " + enteredName);

            //driver.Quit();
        }

    }
}
