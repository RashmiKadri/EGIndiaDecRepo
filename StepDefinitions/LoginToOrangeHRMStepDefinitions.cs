using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class LoginToOrangeHRMStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private IWebDriver _driver = null;

        public LoginToOrangeHRMStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _driver = _scenarioContext["WebDriver"] as IWebDriver;
        }
        [Given(@"User is on the orange hrm login page")]
        public void GivenUserIsOnTheOrangeHrmLoginPage()
        {
            _driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }

        [When(@"User enters the ""([^""]*)"" and ""([^""]*)"" in the text fields")]
        public void WhenUserEntersTheAndInTheTextFields(string usrname, string passwd)
        {
            IWebElement username = _driver.FindElement(By.XPath("//input[@name = 'username']"));

            username.SendKeys(usrname);


            IWebElement password = _driver.FindElement(By.XPath("//input[@name = 'password']"));

            password.SendKeys(passwd);


        }

        [When(@"User clicks on submit button")]
        public void WhenUserClicksOnSubmitButton()
        {

            IWebElement loginbutton = _driver.FindElement(By.XPath("//button[@type = 'submit']"));

            loginbutton.Click();

            Thread.Sleep(4000);

        }

        [Then(@"User is navigated to home page")]
        public void ThenUserIsNavigatedToHomePage()
        {

            IWebElement Admin = _driver.FindElement(By.XPath("(//a[@class = 'oxd-main-menu-item'])[1]"));

            Admin.Click();

        }
        [Then(@"User is on the home page and a error is displayed")]
        public void ThenUserIsOnTheHomePageAndAErrorIsDisplayed()
        {
            IWebElement MessageForInvalid = _driver.FindElement(By.XPath("//p[@class='oxd-text oxd-text--p oxd-alert-content-text']"));
            string message = MessageForInvalid.Text;
            Assert.AreEqual(message, "Invalid credentials");
        }



        [Then(@"Logo is displayed successfully")]
        public void ThenLogoIsDisplayedSuccessfully()
        {
            IWebElement Logo = _driver.FindElement(By.XPath("//div[@class='orangehrm-login-branding']"));
            Assert.IsNotNull(Logo);


        }
        [When(@"User clicks on forgot password link")]
        public void WhenUserClicksOnForgotPasswordLink()
        {
            IWebElement ForgotPassword = _driver.FindElement(By.XPath("//p[@class='oxd-text oxd-text--p orangehrm-login-forgot-header']"));
            ForgotPassword.Click();
            Thread.Sleep(2000);

        }

        [Then(@"User is navigated to Change Password url")]
        public void ThenUserIsNavigatedToChangePasswordUrl()
        {

            IWebElement ResetPassword = _driver.FindElement(By.XPath("//h6[normalize-space()='Reset Password']"));
            string message = ResetPassword.Text;
            Console.WriteLine(message);

            Assert.AreEqual(message, "Reset Password");

        }
        [When(@"User enters the ""([^""]*)"" and ""([^""]*)""")]
        public void WhenUserEntersTheAnd(string username, string password)
        {
            IWebElement user = _driver.FindElement(By.XPath("//input[@name = 'username']"));

            user.SendKeys(username);


            IWebElement pass = _driver.FindElement(By.XPath("//input[@name = 'password']"));

            pass.SendKeys(password);
            Console.WriteLine("The username is " + username + "....." + "The passowrd is " + password);
            Thread.Sleep(1000);
        }

        [Then(@"User is naviagted to home page")]
        public void ThenUserIsNaviagtedToHomePage()
        {
            IWebElement HomePage = _driver.FindElement(By.XPath("//img[@alt='client brand banner']"));
            string message = HomePage.Text;
            Console.WriteLine(message);
        }

        [Then(@"User selects city and country information")]
        public void ThenUserSelectsCityAndCountryInformation(Table table)
        {
            foreach (var row in table.Rows)
            {
                string city = row["city"];
                string country = row["country"];
                Console.WriteLine(city + "," + country);

            }

        }
    }
}

