using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Xunit;
using OpenQA.Selenium.Support.UI;
using static OpenQA.Selenium.BiDi.Modules.Network.UrlPattern;
using System.Text.RegularExpressions;

namespace Learn_CSharp.Selenium.testcase
{
    internal class CreateLead

    {
        static string companyName = "Qeagle";
        static string firstName = "Ramkumar";
        static string lastName = "Ramaiah";
        static string source = "Employee";
        static string title = "Mr.";
        static string industry = "IND_SOFTWARE";
        static int ownership = 5;
        static string desc = "Automation Tester";

        static void Main(string[] args)
        {
            // Initialize WebDriver
            ChromeDriver driver = new ChromeDriver();
            // Set an implicit wait of 15 seconds
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            // Create an explicit wait instance with a 30-second timeout
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

           
            try
            {
                // Open a URL
                driver.Navigate().GoToUrl("http://leaftaps.com/opentaps/control/main");

                // Maximize browser window
                driver.Manage().Window.Maximize();

                // Locate elements and interact with them
                driver.FindElement(By.Id("username")).SendKeys("demosalesmanager");
                driver.FindElement(By.Id("password")).SendKeys("crmsfa");

                // Click the login button
                driver.FindElement(By.XPath("//input[@value='Login']")).Click();

                // Retrieve and print text from an element
                IWebElement crmsfa = driver.FindElement(By.XPath("//a[contains(text(),'CRM')]"));
                // Wait for an element to be clickable
                IWebElement element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((By)crmsfa));
                Console.WriteLine("Home Page Message : " + crmsfa.Text);
                Assert.True(driver.FindElement(By.XPath("//a[contains(text(),'CRM')]")).Displayed);

                // Click CRM/SFA
                crmsfa.Click();

                // Click Leads Tab
                driver.FindElement(By.XPath("//a[text()='Leads']")).Click();

                // Click Create Lead
                driver.FindElement(By.XPath("//a[text()='Create Lead']")).Click();

                // Type Company Name
                driver.FindElement(By.XPath("//span[text()='Company Name']//following::input[1]")).SendKeys(CreateLead.companyName);

                // Type First Name
                driver.FindElement(By.XPath("//span[text()='First name']//following::input[1]")).SendKeys(firstName);

                // Type Last Name
                driver.FindElement(By.XPath("//span[text()='Last name']//following::input[1]")).SendKeys(lastName);

                // Select Source using Dropdown
                  // Locate the dropdown element
                IWebElement selectDD = driver.FindElement(By.XPath("//span[text()='Source']//following::select[1]"));
                  // Create a SelectElement object
                SelectElement sourceDD = new SelectElement(selectDD);
                  // Select by visible text
                sourceDD.SelectByText(source);

                // Type Title 
                driver.FindElement(By.XPath("//span[text()='Title']//following::input[1]")).SendKeys(title);

                // Select Industry
                  // Locate the dropdown element
                IWebElement selectDD2 = driver.FindElement(By.XPath("//span[text()='Industry']//following::select[1]"));
                  // Create a SelectElement object
                SelectElement industryDD = new SelectElement(selectDD2);
                  // Select by Value
                industryDD.SelectByValue(industry);

                // Select Ownership
                  // Locate the dropdown element
                IWebElement selectDD3 = driver.FindElement(By.XPath("//span[text()='Ownership']//following::select[1]"));
                  // Create a SelectElement object
                SelectElement ownershipDD = new SelectElement(selectDD3);
                // Select by Index
                ownershipDD.SelectByIndex(ownership);

                // Enter Description
                driver.FindElement(By.XPath("//span[text()='Description']//following::textarea[1]")).SendKeys(desc);

                // Click Create Lead Button
                driver.FindElement(By.XPath("//input[@value='Create Lead'] ")).Click();

                // Verify Company Name and Lead Id
                IWebElement companyName = driver.FindElement(By.XPath("//span[contains(@id,'viewLead_companyName')]"));
                string cName = companyName.Text;
                Console.WriteLine("Company Name :- "+cName);

                Match match = Regex.Match(cName, @"\d+");
                Console.WriteLine("Lead ID :- " + match);

            }
            finally
            {
                // Close the browser
               // driver.Quit();
            }
        }
    }
}
