using System;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class RahulAngularPracticeStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private IWebDriver _driver = null;
        public RahulAngularPracticeStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _driver = _scenarioContext["WebDriver"] as IWebDriver;
        }
        [Given(@"Load the practice url")]
        public void GivenLoadThePracticeUrl()
        {
            _driver.Navigate().GoToUrl("https://rahulshettyacademy.com/angularpractice/");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }

        [When(@"User enters the data in Name, Password, Email Field")]
        public void WhenUserEntersTheDataInNamePasswordEmailField(Table table)
        {
            IWebElement name = _driver.FindElement(By.XPath("(//input[@name='name'])[1]"));
            IWebElement email = _driver.FindElement(By.XPath("//input[@name='email']"));
            IWebElement password = _driver.FindElement(By.XPath("//input[@id='exampleInputPassword1']"));

            foreach (var row in table.Rows)
            {
                string Name = row["Name"];
                name.SendKeys(Name);
                string Password = row["Password"];
                password.SendKeys(Password);
                string Email = row["Email"];
                email.SendKeys(Email);     
                Console.WriteLine(Name + "," + Password + "," +Email);
            }
        }

        [Then(@"Data entered in Name, Password and Email field")]
        public void ThenDataEnteredInNamePasswordAndEmailField()
        {
            Console.WriteLine("Data is entered successfully");
        }

        [Then(@"User selects gender and status")]
        public void ThenUserSelectsGenderAndStatus()
        {
            IWebElement status = _driver.FindElement(By.XPath("//input[@id='inlineRadio1']"));
            status.Click();     
        }
        [Then(@"User enters DOB")]
        public void ThenUserEntersDOB()
        {
            IWebElement DOB = _driver.FindElement(By.XPath("//input[@name='bday']"));
            DOB.Click();
        }

    }
}