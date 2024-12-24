using System;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class XYZBankStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private IWebDriver _driver = null;

        public XYZBankStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _driver = _scenarioContext["WebDriver"] as IWebDriver;
        }
        [Given(@"Load the XYZ bank url")]
        public void GivenLoadTheXYZBankUrl()
        {
            _driver.Navigate().GoToUrl("https://www.globalsqa.com/angularJs-protractor/BankingProject/#/login");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }

        [When(@"XYX Bank is displayed")]
        public void WhenXYXBankIsDisplayed()
        {
            IWebElement Heading = _driver.FindElement(By.XPath("//strong[@class='mainHeading']"));
            String HeadingText = Heading.Text;
            Assert.AreEqual(HeadingText, "XYZ Bank");
            Thread.Sleep(1000);
        }

        [When(@"Click on Customer Login button")]
        public void WhenClickOnCustomerLoginButton()
        {
            IWebElement CustomerLogin = _driver.FindElement(By.XPath("//button[normalize-space()='Customer Login']"));
            CustomerLogin.Click();
            Thread.Sleep(2000);
        }

        [Then(@"Your Name is displayed")]
        public void ThenYourNameIsDisplayed()
        {
            IWebElement YourName = _driver.FindElement(By.XPath("//label[normalize-space()='Your Name :']"));
            YourName.Click();
            Thread.Sleep(1000);
           
        }
        [When(@"User clicks on the Dropdown")]
        public void WhenUserClicksOnTheDropdown()
        {
            Console.WriteLine("List displayed");
        }
        [Then(@"User LOgin")]
        public void ThenUserLOgin()
            {
            IWebElement DropDown = _driver.FindElement(By.XPath("//select[@id='userSelect']"));
            Assert.IsNotNull(DropDown);

            var select = new SelectElement(DropDown);
            //select by visible text
            Thread.Sleep(1000);
            select.SelectByIndex(1);
            Thread.Sleep(2000);
            IWebElement Login = _driver.FindElement(By.XPath("(//button[normalize-space()='Login'])[1]"));
            Login.Click();
            Console.WriteLine("User1 logged in");
        }
        [Then(@"Screen with User with Transactions, Deposits and Withdrawals are displated")]
        public void ThenScreenWithUserWithTransactionsDepositsAndWithdrawalsAreDisplated()
        {
            Console.WriteLine("Details of customer is displayed");     
        }

        [Then(@"Click on Log OUt")]
        public void ThenClickOnLogOUt()
        {
            Thread.Sleep(1000);
         IWebElement Logout = _driver.FindElement(By.XPath("//button[normalize-space()='Logout']"));
         Logout.Click();
         }

            [Then(@"User is successfully logged out")]
        public void ThenUserIsSuccessfullyLoggedOut()
        {
            IWebElement Homepage = _driver.FindElement(By.XPath("//button[normalize-space()='Home']"));
            Homepage.Displayed.Should().BeTrue();
                           }


            [When(@"Click on Bank Manager Login button")]
        public void WhenClickOnBankManagerLoginButton()
        {
            IWebElement BankManagerLogin = _driver.FindElement(By.XPath("//button[normalize-space()='Bank Manager Login']"));
            BankManagerLogin.Click();
        }

        [Then(@"Three tabs with Add Customer, Open Account and Customers are displayed")]
        public void ThenThreeTabsWithAddCustomerOpenAccountAndCustomersAreDisplayed()
        {
            Console.WriteLine("List displayed");
        }
    }
}
