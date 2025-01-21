using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace Learn_CSharp.Selenium.leafground
{
    internal class LearnWebTable
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            // Navigate to leafground
            driver.Navigate().GoToUrl("https://leafground.com/");

            // Maximize browser window
            driver.Manage().Window.Maximize();

            // Click Table
            driver.FindElement(By.XPath("//span[text()='Table']//parent::a")).Click();

            // Click Table sub menu
            driver.FindElement(By.XPath("(//span[text()='Table']//parent::a)[2]")).Click();

            // Retrieve all rows
            IList<IWebElement> rows = driver.FindElements(By.XPath("//tbody[contains(@class,'widget-content')]//tr"));
            Console.WriteLine("Number of rows: " + rows.Count);

            
            // Retrieve cells from the first row (excluding header)
            IList<IWebElement> cells = rows[0].FindElements(By.TagName("td"));
            foreach (IWebElement allCell in cells)
            {
                Console.WriteLine("Cell Value: " + allCell.Text);
            }

            // Iterate through rows and print data
            foreach (IWebElement row in rows)
            {
                IList<IWebElement> totalCells = row.FindElements(By.TagName("td"));
                foreach (IWebElement totalCell in totalCells)
                {
                    Console.Write(totalCell.Text + "|");
                }
                Console.WriteLine();
            }

            // Cast WebDriver to ITakesScreenshot
            ITakesScreenshot screenshotDriver = (ITakesScreenshot)driver;

            // Take the screenshot
            Screenshot screenshot = screenshotDriver.GetScreenshot();

            // Saving Screenshot with Dynamic Names
            string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");

            // Save the screenshot to a file
            string filePath = $"C:\\Screenshots\\screenshot_{timestamp}.png";
            screenshot.SaveAsFile(filePath);

            Console.WriteLine("Screenshot saved at: " + filePath);



        }
    }
}
