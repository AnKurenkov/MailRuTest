using OpenQA.Selenium;

namespace SpecFlowProject2.Pages
{
    public class LoginPage
    {
        protected WebDriver driver;
        
        //private IWebElement userNameTextField;

        private By usernameBy = By.Name("username");
        private By nextButtonBy = By.CssSelector("button[data-test-id='next-button']");
        private By passwordBy = By.Name("password");
        private By submitButtonBy = By.CssSelector("button[data-test-id='submit-button']");

        public LoginPage(WebDriver driver)
        {
            this.driver = driver;
        }

        public LoginPage EnterUsername(String userName)
        {
            driver.FindElement(usernameBy).SendKeys(userName);

            return new LoginPage(driver);
        }

        public String GetUsername()
        {            
            String userName = driver.FindElement(usernameBy).GetAttribute("value");
            return userName;
        }

        public LoginPage ClickNextButton()
        {
            driver.FindElement(nextButtonBy).Click();

            return new LoginPage(driver);
        }

        public LoginPage EnterPassword(String userPassword)
        {
            driver.FindElement(passwordBy).SendKeys(userPassword);

            return new LoginPage(driver);
        }

        public HomePage ClickSubmitButton()
        {
            driver.FindElement(submitButtonBy).Click();

            return new HomePage(driver);
        }
    }
}