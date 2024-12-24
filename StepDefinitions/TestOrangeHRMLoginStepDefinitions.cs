using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;
using WebDriverManager.DriverConfigs.Impl;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class TestOrangeHRMLoginStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private IWebDriver _driver;

        public TestOrangeHRMLoginStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _driver = _scenarioContext["WebDriver"] as IWebDriver;
        }
        [Given(@"User is on Login Page")]
        public void GivenUserIsOnLoginPage()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
            _driver = new FirefoxDriver();
            _driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
        }

        [When(@"User enters the Username and Password")]
        public void WhenUserEntersTheUsernameAndPassword()
        {
            IWebElement UserName = _driver.FindElement(By.XPath("//input[@name='username']"));
            UserName.SendKeys("Admin");

            IWebElement Password = _driver.FindElement(By.XPath("//input[@name='password']"));
            Password.SendKeys("admin123");
        }

        [When(@"User clicks on Login Button")]
        public void WhenUserClicksOnLoginButton()
        {

            IWebElement Login = _driver.FindElement(By.XPath("//button[@type='submit']"));
            Login.Click();
        }

        [Then(@"User is navigated to HomePage")]
        public void ThenUserIsNavigatedToHomePage()
        {
            Console.WriteLine("Log successfull");
        }
    }
}
