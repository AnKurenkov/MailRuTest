using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using SpecFlowProject2.Pages;
using NUnit.Framework;

namespace SpecFlowProject2.StepDefinitions
{
    [Binding]
    public class MailRuLogInStepDefinitions
    {
        private String test_url = "https://account.mail.ru/login/";
        private String test_username = "ant_test_001@mail.ru";
        private String test_password = "MyPass_001";

        private WebDriver driver;

        private readonly ScenarioContext context;

        public MailRuLogInStepDefinitions(ScenarioContext injectedContext)
        {
            this.context = injectedContext;
        }

        [Given(@"that User on the login page of MailRu")]
        public void GivenThatUserOnTheLoginPageOfMailRu()
        {
            driver = new EdgeDriver();
            driver.Url = test_url;
            driver.Manage().Window.Maximize();
            System.Threading.Thread.Sleep(2000);            
        }

        [When(@"User enter and check username")]
        public void WheUserEnterAndCheckUsername()
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.EnterUsername(test_username);
            Assert.That(loginPage.GetUsername(), Is.EqualTo(test_username));
        }

        [When(@"User click next button")]
        public void WhenUserClickNextButton()
        {
            LoginPage loginPage = new LoginPage(driver);

            loginPage.ClickNextButton();
            System.Threading.Thread.Sleep(2000);
        }

        [When(@"User enter password")]
        public void WhenUserEnterPassword()
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.EnterPassword(test_password);
        }

        [When(@"User click submit button")]
        public void WhenUserClickSubmitButton()
        {
            LoginPage loginPage = new LoginPage(driver);

            loginPage.ClickSubmitButton();
            System.Threading.Thread.Sleep(2000);
        }

        [Then(@"check User name on HomePage")]
        public void ThenCheckUserNameOnHomePage()
        {
            HomePage homePage = new HomePage(driver);

            Assert.That(homePage.GetUsername(), Is.EqualTo(test_username));

            driver.Quit();
        }
    }
}
