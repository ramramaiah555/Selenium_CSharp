using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace Learn_CSharp.Selenium.testcase
{
    class SnapdealAutomation
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            Actions actions = new Actions(driver);

            try
            {
                // Navigate to Snapdeal
                driver.Navigate().GoToUrl("https://www.snapdeal.com/");
                // Wait for page load
                wait.Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));

                // Hover over Men's Fashion
                IWebElement mensFashion = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[text()=\"Men's Fashion\"]")));
                actions.MoveToElement(mensFashion).Perform();

                // Click on Sports Shoes
                IWebElement sportsShoes = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[text()='Sports Shoes']")));
                sportsShoes.Click();

                // Get sports shoes text
                IWebElement shoesTextElement = driver.FindElement(By.XPath("//div[text()='Sports Shoes for Men']/following-sibling::div"));
                string shoesText = shoesTextElement.Text;
                Console.WriteLine(shoesText);

                // Click on Training Shoes
                IWebElement trainingShoes = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[text()='Training Shoes']")));
                trainingShoes.Click();

                // Hover over the first shoe
                IWebElement firstShoe = wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.CssSelector("div[class$='favDp product-tuple-listing js-tuple ']")))[0];
                actions.MoveToElement(firstShoe).Perform();

                // Click Quick View
                IWebElement quickView = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[contains(@class,'clearfix row-disc')]//div[text()='Quick View']")));
                quickView.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occurred: {ex.Message}");
            }
            finally
            {
                driver.Quit();
            }
        }
    }
}
