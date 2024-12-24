using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using TechTalk.SpecFlow;
using WebDriverManager.DriverConfigs.Impl;

//[assembly: Parallelizable(ParallelScope.All)]
namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class ParallelExecutionTestingStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private IWebDriver _driver = null;
        public ParallelExecutionTestingStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _driver = _scenarioContext["WebDriver"] as IWebDriver;
        }
        [Given(@"User is on the applicaion page on IE")]
        public void GivenUserIsOnTheApplicaionPageOnIE()
        {
            //new WebDriverManager.DriverManager().SetUpDriver(new InternetExplorerConfig());
            //_driver = new InternetExplorerDriver();
            _driver.Navigate().GoToUrl("https://rahulshettyacademy.com/angularpractice/");
            _driver.Manage().Window.Maximize();
                Thread.Sleep(2000);
            
        }

        [Given(@"User is on the applicaion page on Firefox")]
        public void GivenUserIsOnTheApplicaionPageOnFirefox()
        {
            //new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
            //_driver = new FirefoxDriver();
            _driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login/");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }

        [Given(@"User is on the applicaion page on Edge")]
        public void GivenUserIsOnTheApplicaionPageOnEdge()
        {
            //new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
            //_driver = new EdgeDriver();
            _driver.Navigate().GoToUrl("https://docs.specflow.org/en/latest/");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }
    }
}
